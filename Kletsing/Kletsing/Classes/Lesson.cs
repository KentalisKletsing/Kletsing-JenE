using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kletsing.Classes
{
    public class Lesson
    {
        public int id { get; private set; }
        public string email { get; set; }
        public string lessonName { get; set; }

        public string klaarzetten { get; set; }

        public string groepsopstelling { get; set; }

        public string introductie { get; set; }

        public string passief { get; set; }

        public string actief { get; set; }

        public string zingen { get; set; }

        public string variaties { get; set; }

        public List<String> songs { get; set; }


        public Lesson(int id, string email)
        {
            this.id = id;
            this.email = email;
            songs = new List<string>();
        }

        public Lesson(string email)
        {
            this.email = email;
            songs = new List<string>();
        }
    }
}
