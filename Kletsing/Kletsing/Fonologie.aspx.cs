using Kletsing.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class Fonologie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> categorien = new List<String>();

            DBController db = new DBController();

            //Vaste categorien
            categorien.Add("Spondeeën");
            categorien.Add("Klanken vroege ontwikkeling");
            categorien.Add("Cluster");
            categorien.Add("Fricatieven");
            categorien.Add("Contrast voor/achter");
            categorien.Add("Liquidae L");
            categorien.Add("Liquidae R");
            categorien.Add("Naselen");
            categorien.Add("Glijklanken");

            repeaterFonologie.DataSource = categorien;
            repeaterFonologie.DataBind();
        }

        public void linkbtnCategorie_Click(object sender, CommandEventArgs e)
        {
            //één dynamische pagina, of meerdere statische pagina's?

            //string url = "LiedPagina.aspx?woord=" + e.CommandArgument;
            //Response.Redirect(url);
        }
    }
}