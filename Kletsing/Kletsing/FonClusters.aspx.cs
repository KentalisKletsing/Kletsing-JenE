using Kletsing.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class FonClusters : System.Web.UI.Page
    {
        List<String> clusters = new List<String>();
        protected void Page_Load(object sender, EventArgs e)
        {
            clusters.Add("B-clusters");
            clusters.Add("S-clusters");
            clusters.Add("L-clusters");
            clusters.Add("K-clusters");
            clusters.Add("R-clusters");

            repeaterCluster.DataSource = clusters;
            repeaterCluster.DataBind();
        }

        public void linkCluster_Click(object sender, CommandEventArgs e)
        {
            string url = "Woord.aspx?cat=" + e.CommandArgument;
            Response.Redirect(url);
        }
    }
}