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
    public partial class LesDetail : System.Web.UI.Page
    {
        Lesson lesson;
        DBController db;
        protected void Page_Load(object sender, EventArgs e)
        {
            var chosen_lesson = Request.QueryString["les"];
            if (chosen_lesson != null)
            {
                db = new DBController();
                int id = 0;
                Int32.TryParse(chosen_lesson, out id);
                lesson = db.getLessonById(id);
                lblLessonName.Text = lesson.lessonName;
                lblKlaarzetten.Text = lesson.klaarzetten;
                lblGroepsopstelling.Text = lesson.groepsopstelling;
                lblIntroductie.Text = lesson.introductie;
                lblPassief.Text = lesson.passief;
                lblActief.Text = lesson.actief;
                lblZingen.Text = lesson.zingen;
                lblVariaties.Text = lesson.variaties;
            }
            else
            {
                Response.Redirect("Lessen.aspx");
            }
        }
    }
}