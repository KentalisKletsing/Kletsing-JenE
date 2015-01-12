using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kletsing.Controllers;
using System.Data;

namespace Kletsing
{
    public partial class Woord : System.Web.UI.Page
    {
        List<String> songs = new List<String>();

        DBController db = new DBController();
        protected void Page_Load(object sender, EventArgs e)
        {
            var chosen_cat = Request.QueryString["cat"];
            
            if(chosen_cat != null)
            {
                lblCat.Text = chosen_cat.ToString();
                DataTable data = db.getSongsByCat(chosen_cat);
                foreach(DataRow row in data.Rows)
                {
                    String word = row["naam"].ToString();
                    songs.Add(word);
                }

                songs.Sort();

                repeaterSongs.DataSource = songs;
                repeaterSongs.DataBind();
            }
            else
            {
                Response.Redirect("Fonologie.aspx");
            }
        }

        public void linkbtnSong_Click(object sender, CommandEventArgs e)
        {
            db = null;
            string url = "LiedPagina.aspx?woord=" + e.CommandArgument;
            Response.Redirect(url);
        }
    }
}