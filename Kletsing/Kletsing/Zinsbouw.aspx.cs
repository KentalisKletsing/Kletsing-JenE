using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class Zinsbouw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> zinnen = new List<string>();

            for(int i = 1; i <11; i++)
            {
                zinnen.Add(i + "-woordzin");
            }

            repeaterZinslengte.DataSource = zinnen;
            repeaterZinslengte.DataBind();
        }

        public void linkbtnZinLengte_Click(object sender, CommandEventArgs e)
        {
            //één dynamische pagina, of meerdere statische pagina's?

            //string url = "LiedPagina.aspx?woord=" + e.CommandArgument;
            //Response.Redirect(url);
        }
    }
}