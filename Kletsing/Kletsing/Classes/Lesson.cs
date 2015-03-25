using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kletsing.Classes
{
    public class Lesson
    {
        private int id { get; set; }
        private string email { get; set; }
        private string lessonName { get; set; }

        private string klaarzetten { get; set; }

        private string groepsopstelling { get; set; }

        private string introductie { get; set; }

        private string passief { get; set; }

        private string actief { get; set; }

        private string zingen { get; set; }

        private string variaties { get; set; }

        public Lesson(int id, string email)
        {
            this.id = id;
            this.email = email;
        }
    }
}