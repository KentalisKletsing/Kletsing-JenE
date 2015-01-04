using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class WoordThema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> themas = new List<string>();
            themas.Add("Dagelijkse Routines");
            themas.Add("Ik");
            themas.Add("Dieren");
            themas.Add("Feesten");

            themas.Sort();
            repeaterThema.DataSource = themas;
            repeaterThema.DataBind();
        }

        public void linkbtnThema_Click(object sender, CommandEventArgs e)
        {
            string url = "ThemaDetail.aspx?thema=" + e.CommandArgument;
            Response.Redirect(url);
        }
    }
}