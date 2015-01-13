using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Kletsing.Controllers;

namespace Kletsing
{
    public partial class Login : System.Web.UI.Page
    {
        DBController database = new DBController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string password = textPassword.Text;
            if (database.CheckPassword(email, password))
            {
                FormsAuthentication.RedirectFromLoginPage(email, Persist.Checked);
                Session.Add("UserName", textEmail.Text);
            }
            else
            {
                Msg.Text = "Ongeldige login gegevens. Probeer opnieuw.";
            }
        }
    }
}