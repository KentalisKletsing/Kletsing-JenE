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
    public partial class Register : System.Web.UI.Page
    {
        DBController database = new DBController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit1_Click(object sender, EventArgs e)
        {
            if (database.AddUser(TextEmail.Text, TextPassword1.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(TextEmail.Text, false);
                Session.Add("UserName", TextEmail.Text);
            }
            else
            {
                Msg.Text = "Er is iets mis gegaan, probeer het opnieuw.";
            }
        }
    }
}