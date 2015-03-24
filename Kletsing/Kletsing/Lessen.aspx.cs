using Kletsing.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class Lessen : System.Web.UI.Page
    {
        List<String> lessons = new List<String>();

        DBController db = new DBController();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable data = db.getLessons();
            foreach (DataRow row in data.Rows)
            {
                String word = row["lesnaam"].ToString();
                lessons.Add(word);
            }

            lessons.Sort();
            if(lessons.Count == 0)
            {
                lessons.Add("Geen lessen gevonden");
            }
            repeaterLessons.DataSource = lessons;
            repeaterLessons.DataBind();

        }

        public void linkbtnLesson_Click(object sender, CommandEventArgs e)
        {
            int id = db.getLessonIdByLessonName(e.CommandArgument.ToString());
            db = null;

            string url = "LesDetail.aspx?les=" + id;
            Response.Redirect(url);
        }
    }
}