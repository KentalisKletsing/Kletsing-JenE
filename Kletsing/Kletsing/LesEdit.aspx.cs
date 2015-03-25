using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kletsing.Controllers;
using Kletsing.Classes;

namespace Kletsing
{
    public partial class Les_detail : System.Web.UI.Page
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

                if (!IsPostBack)
                {
                    lblLessonName.Text = lesson.lessonName;

                    tbKlaarzetten.Text = lesson.klaarzetten;
                    tbGroepsopstelling.Text = lesson.groepsopstelling;
                    tbIntroductie.Text = lesson.introductie;
                    tbPassief.Text = lesson.passief;
                    tbActief.Text = lesson.actief;
                    tbZingen.Text = lesson.zingen;
                    tbVariaties.Text = lesson.variaties;
                }

            }
            else
            {
                Response.Redirect("Lessen.aspx");
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (lesson != null)
            {
                lesson.klaarzetten = tbKlaarzetten.Text;
                lesson.groepsopstelling = tbGroepsopstelling.Text;
                lesson.introductie = tbIntroductie.Text;
                lesson.passief = tbPassief.Text;
                lesson.actief = tbActief.Text;
                lesson.zingen = tbZingen.Text;
                lesson.variaties = tbVariaties.Text;

                if (db != null)
                {
                    db.updateLessonById(lesson);
                    System.Diagnostics.Debug.WriteLine("update complete");
                }

                System.Diagnostics.Debug.WriteLine("update niet complete");
            }

        }
    }
}