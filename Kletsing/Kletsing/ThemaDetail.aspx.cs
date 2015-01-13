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
    public partial class ThemaDetail : System.Web.UI.Page
    {

        DBController db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DBController();
            List<String> songs = new List<string>();
            songs.Clear();

            var chosen_theme = Request.QueryString["thema"];
            if (chosen_theme != null)
            {
                DataTable data = db.getSongsByTheme(chosen_theme);

                if(data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        String songNaam = row["naam"].ToString();
                        songs.Add(songNaam);
                    }
                }
                else
                {
                    lblNoSongs.Text = "Geen liedjes met thema " + chosen_theme.ToLower();
                }
                
            }
            else
            {
                Response.Redirect("WoordThema.aspx");
            }

            

            repeaterSong.DataSource = songs;
            repeaterSong.DataBind();
        }

        public void linkbtnLiedje_Click(object sender, CommandEventArgs e)
        {
            string url = "LiedPagina.aspx?woord=" + e.CommandArgument;
            Response.Redirect(url);
        }
    }
}