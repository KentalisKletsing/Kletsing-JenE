using Kletsing.Classes;
using Kletsing.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class NewLesson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            string username = (string)(Session["UserName"]);
            if(username == null)
            {
                username = "ericderegter@gmail.com";
            }
            Lesson lesson = new Lesson(username);
            lesson.lessonName = tbName.Text;
            lesson.klaarzetten = tbKlaarzetten.Text;
            lesson.groepsopstelling = tbGroepsopstelling.Text;
            lesson.introductie = tbIntroductie.Text;
            lesson.passief = tbPassief.Text;
            lesson.actief = tbActief.Text;
            lesson.zingen = tbZingen.Text;
            lesson.variaties = tbVariaties.Text;

            DBController db = new DBController();
            db.addLesson(lesson);
            Response.Redirect("Lessen.aspx");
        }
    }
}