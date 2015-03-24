using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Globalization;
using System.Text;
using Kletsing.Classes;
using System.Data;

namespace Kletsing.Controllers
{
    public class DBController
    {
        private MySqlConnection connection;

        /// <summary>
        /// A class for managing the database connection in the Kentalis-Klet's-sing website
        /// </summary>
        public DBController()
        {
            Initialize();
        }

        private void Initialize()
        {
            string connStr = "Server=84.28.193.115;Port=3306;Database=kletsing;Uid=remoteuser;Pwd=420blaze";
            connection = new MySqlConnection(connStr);
        }

        /// <summary>
        /// Opens the database connection
        /// </summary>
        /// <returns>Bool wether the operation succeeded</returns>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to database");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password for database");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Closes the database connection
        /// </summary>
        /// <returns></returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Everything to do with 'user'
        /// <summary>
        /// Hashes the password and checks it with the hashed password stored in the database
        /// </summary>
        /// <param name="userEmail">The user's email to check the password of</param>
        /// <param name="password">The password to check</param>
        /// <returns>True: Password is the same; False: Password is not the same.</returns>
        public bool CheckPassword(string userEmail, string password)
        {
            try
            {
                OpenConnection();
                string query = "SELECT password FROM User WHERE email = @param_email";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@param_email", userEmail);
                string pw = Convert.ToString(command.ExecuteScalar());
                if (pw == GetPasswordHash(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }

        /// <summary>
        /// Adds a user with the specified email and password to the database
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="password"></param>
        public bool AddUser(string userEmail, string password)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO User (email, password, soort) VALUES (@param_email, @param_password, 'default')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@param_email", userEmail);
                command.Parameters.AddWithValue("@param_password", GetPasswordHash(password));
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }

        /// <summary>
        /// Returns a hashed value of the entered password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string GetPasswordHash(string password)
        {
            if (password != null)
            {
                Console.WriteLine("Test getPassword");
                UnicodeEncoding encoding = new UnicodeEncoding();
                byte[] binaryPassword = encoding.GetBytes(password);
                byte[] hashValue = (new MD5CryptoServiceProvider()).ComputeHash(binaryPassword);
                string hashedPassword = String.Empty;
                foreach (byte b in hashValue)
                {
                    hashedPassword += b.ToString("X2", CultureInfo.InvariantCulture.NumberFormat);
                }
                return hashedPassword;
            }
            return null;
        }

        //Everything to do with 'letter'

        /// <summary>
        /// Gets a DataTable with characters and the amount of words that start with said character from the database.
        /// </summary>
        /// <returns></returns>
        public DataTable GetLetters()
        {
            try
            {
                OpenConnection();
                DataTable data = new DataTable("Letters");
                string query = "SELECT l.letter as Letter, count(w.woord) as Aantal FROM woord w RIGHT JOIN letter l ON w.letter = l.letter GROUP BY l.letter;";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                data.Load(reader);

                return data;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }


        ////Everything to do with 'word'

        /// <summary>
        /// Gets a datatable with all the words
        /// </summary>
        /// <returns></returns>
        public DataTable GetWords(String letter)
        {
            try
            {
                OpenConnection();
                DataTable data = new DataTable("Woorden");

                //Query nog maken
                string query = "Select * From Woorden WHERE categorie = @param_letter";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@param_letter", letter.ToLower());
                MySqlDataReader reader = command.ExecuteReader();
                data.Load(reader);
                return data;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }

        /// <summary>
        /// Adds a word to the database
        /// </summary>
        /// <param name="word">The new word to be added</param>
        public bool AddWord(String word, String cat, String soortWoord)
        {
            try
            {
                OpenConnection();

                //Query nog maken
                string queryCheck = "SELECT woord FROM Woorden WHERE = woord = @word";
                MySqlCommand commandCheck = new MySqlCommand(queryCheck, connection);
                commandCheck.Parameters.AddWithValue("@word", word);
                if (Convert.ToString(commandCheck.ExecuteScalar()) == word)
                {
                    return false;
                }
                else
                {
                    //Query waarschijnlijk nog aanpassen
                    string queryAdd = "INSERT INTO Woorden (naam, categorie, soortWoord) VALUES (@woord, @categorie, @soortWoord)";
                    MySqlCommand commandAdd = new MySqlCommand(queryAdd, connection);
                    commandAdd.Parameters.AddWithValue("@woord", word);
                    commandAdd.Parameters.AddWithValue("@categorie", cat);
                    commandAdd.Parameters.AddWithValue("@soortWoord", soortWoord);
                    commandAdd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }

        public DataTable getSongsByCat(String cat)
        {
            try
            {
                OpenConnection();
                DataTable data = new DataTable("data");
                string query = "Select Liedje.id, Liedje.naam, Liedje.thema From Liedje, CategorieLied Where Liedje.id = CategorieLied.id and categorie = @param_cat";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@param_cat", cat);
                MySqlDataReader reader = command.ExecuteReader();
                data.Load(reader);
                return data;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public DataTable getWordsByCat(String cat)
        {
            try
            {
                OpenConnection();
                DataTable data = new DataTable("data");
                string query = "Select woord, categorie, soortWoord From Woorden where categorie = @param_cat";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@param_cat", cat);
                MySqlDataReader reader = command.ExecuteReader();
                data.Load(reader);
                return data;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public DataTable getSongsByTheme(String theme)
        {
            try
            {
                OpenConnection();
                DataTable data = new DataTable("data");
                string query = "SELECT * FROM Liedje where thema = @param_theme";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@param_theme", theme.ToLower());
                MySqlDataReader reader = command.ExecuteReader();
                data.Load(reader);
                return data;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public DataTable getLessons()
        {
            try
            {
                OpenConnection();
                DataTable data = new DataTable("data");
                string query = "SELECT lesnaam FROM les";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();
                data.Load(reader);
                return data;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;

        }

        public int getLessonIdByLessonName(string lessonName)
        {
            int result_id = 0;
            try
            {
                OpenConnection();
                DataTable data = new DataTable("data");
                string query = "SELECT id FROM les WHERE lesnaam = @param_lesnaam";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("param_lesnaam", lessonName);
                result_id = (int) command.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result_id;
        }

        public Lesson getLessonById(int id)
        {
            try
            {
                OpenConnection();
                DataTable data = new DataTable("data");
                string query = "SELECT * FROM les where id = @param_id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@param_id", id);
                MySqlDataReader reader = command.ExecuteReader();
                data.Load(reader);
                
                foreach(DataRow row in data.Rows)
                {
                    
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }
    }
}