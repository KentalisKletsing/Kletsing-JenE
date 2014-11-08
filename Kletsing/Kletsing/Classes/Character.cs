using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kletsing.Classes
{
    public class Character
    {
        public string Value
        {
            get;
            private set;
        }
        public int amountOfWords
        {
            get;
            private set;
        }

        public Character(string value, int amountOfWords)
        {
            this.Value = value;
            this.amountOfWords = amountOfWords;
        }

    }
}