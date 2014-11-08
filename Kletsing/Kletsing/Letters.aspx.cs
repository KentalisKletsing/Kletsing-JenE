using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kletsing.Controllers;

namespace Kletsing
{
    public partial class Letters : System.Web.UI.Page
    {
        private DBController database = new DBController();
        protected void Page_Load(object sender, EventArgs e)
        {
            LetterTable.DataSource = database.GetLetters();
            LetterTable.DataBind();
        }

        protected void LetterTable_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(LetterTable, "Select$" + e.Row.RowIndex);
            }
        }

        protected void LetterTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in LetterTable.Rows)
            {
                if (row.RowIndex == LetterTable.SelectedIndex)
                {
                    row.CssClass = "active";
                }
                else
                {
                    row.CssClass = string.Empty;
                }
            }
        }
    }
}