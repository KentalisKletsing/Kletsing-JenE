using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Globalization;
using System.Text;

namespace Kletsing.Controllers
{
    public class DBController
    {
        private MySqlConnection connection;
        private static int SaltValueSize = 4;

        /// <summary>
        /// A class for managing the database connection in the Kentalis-Klet's-sing website
        /// </summary>
        public DBController()
        {
            Initialize();
        }

        private void Initialize()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
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

        /// <summary>
        /// Hashes the password and checks it with the hashed password stored in the database
        /// </summary>
        /// <param name="userEmail">The user's email to check the password of</param>
        /// <param name="password">The password to check</param>
        /// <returns>True: Password is the same; False: Password is not the same.</returns>
        public bool CheckPassword(string userEmail, string password)
        {
            string query = "SELECT password FROM kletsing WHERE email = @param_email;";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@param_email", userEmail);
            string pw = Convert.ToString(command.ExecuteScalar());
            if (pw == GetPasswordHash(pw))
            {
                return true;
            }
            else
            {
                return false;
            }
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
                UnicodeEncoding encoding = new UnicodeEncoding();
                byte[] binaryPassword = encoding.GetBytes(password);
                byte[] hashValue = (new SHA1CryptoServiceProvider()).ComputeHash(binaryPassword);
                string hashedPassword = String.Empty;
                foreach (byte b in hashValue)
                {
                    hashedPassword += b.ToString("X2", CultureInfo.InvariantCulture.NumberFormat);
                }
                return hashedPassword;
            }
            return null;
        }
    }
}