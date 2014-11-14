using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Kletsing
{
    public class RandomString
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public static string createRandomString(int size, int position, string letter)
        {
            StringBuilder builder = new StringBuilder();
            char ch;

            if(position  == 1)
            {
                builder.Append(letter);
                for (int i = 0; i < size; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }

                return builder.ToString().Substring(0,1) + builder.ToString().Substring(1).ToLower();
            }
            else if (position == 2)
            {
                for (int i = 0; i < size/2; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }
                builder.Append(letter);
                for (int i = 0; i < size / 2; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }
                return builder.ToString().Substring(0, 1) + builder.ToString().Substring(1).ToLower();
            }
            else if (position == 3)
            {
                for (int i = 0; i < size; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }
                builder.Append(letter);
                return builder.ToString().Substring(0, 1) + builder.ToString().Substring(1).ToLower();
            }
            else
            {
                return "";
            }
        }
    }
}