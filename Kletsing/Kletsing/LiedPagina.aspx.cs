using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class LiedPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var chosen_word = Request.QueryString["woord"];
            if(chosen_word != null)
            {
                lblGekozen_lied.Text = chosen_word.ToString();
            }
            else
            {
                Response.Redirect("Letters.aspx");
            }
        }
    }
}