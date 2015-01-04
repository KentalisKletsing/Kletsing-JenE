using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class ThemaDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var chosen_word = Request.QueryString["thema"];
            if (chosen_word != null)
            {
                lblGekozen_thema.Text = chosen_word.ToString();
            }
            else
            {
                Response.Redirect("WoordThema.aspx");
            }

            List<String> testSongs = new List<string>();
            testSongs.Add("Stip");
            testSongs.Add("Stoel");
            testSongs.Add("Stok");

            repeaterSong.DataSource = testSongs;
            repeaterSong.DataBind();
        }

        public void linkbtnLiedje_Click(object sender, CommandEventArgs e)
        {
            string url = "LiedPagina.aspx?woord=" + e.CommandArgument;
            Response.Redirect(url);
        }
    }
}