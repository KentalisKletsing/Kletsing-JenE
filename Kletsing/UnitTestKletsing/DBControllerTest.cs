using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kletsing.Controllers;
using Kletsing.Classes;
using System.Collections.Generic;
using System.Text;

namespace UnitTestKletsing
{
    [TestClass]
    public class DBControllerTest
    {
        [TestMethod]
        public void TestUser()
        {
            DBController database = new DBController();
            string email = RandomString(6);
            string password = RandomString(6);
            database.AddUser(email, password);
            Assert.IsTrue(database.CheckPassword(email, password));
        }

        private string RandomString(int size)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
