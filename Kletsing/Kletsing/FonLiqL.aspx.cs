using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class FonLiqL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void linkbtnSong_Click(object sender, CommandEventArgs e)
        {
            string url = "LiedPagina.aspx?woord=" + e.CommandArgument;
            Response.Redirect(url);
        }
    }
}