using Kletsing.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class FonFricatieven : System.Web.UI.Page
    {
        List<String> FBeginValues;
        List<String> FEndValues;
       
        List<String> GBeginValues;
        List<String> GEndValues;
        
        List<String> SBeginValues;
        List<String> SEndValues;
        
        List<String> VBeginValues;
        List<String> VEndValues;
        
        List<String> ZBeginValues;
        List<String> ZEndValues;
        DBController db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DBController();
            FBeginValues = new List<String>();
            FEndValues = new List<String>();

            GBeginValues = new List<String>();
            GEndValues = new List<String>();

            SBeginValues = new List<String>();
            SEndValues = new List<String>();

            VBeginValues = new List<String>();
            VEndValues = new List<String>();

            ZBeginValues = new List<String>();
            ZEndValues = new List<String>();

            DataTable dataF = db.getWordsByCat("f");
            DataTable dataG = db.getWordsByCat("g");
            DataTable dataS = db.getWordsByCat("s");
            DataTable dataV = db.getWordsByCat("v");
            DataTable dataZ = db.getWordsByCat("z");

            readDataTable(dataF, FBeginValues, FEndValues);
            readDataTable(dataG, GBeginValues, GEndValues);
            readDataTable(dataS, SBeginValues, SEndValues);
            readDataTable(dataV, VBeginValues, VEndValues);
            readDataTable(dataZ, ZBeginValues, ZEndValues);

            FBeginValues.Sort();
            FBeginValues.Sort();

            GBeginValues.Sort();
            GBeginValues.Sort();

            SBeginValues.Sort();
            SBeginValues.Sort();

            VBeginValues.Sort();
            VBeginValues.Sort();

            ZBeginValues.Sort();
            ZBeginValues.Sort();

            bindData(repeaterFBegin, FBeginValues);
            bindData(repeaterFEnd, FEndValues);

            bindData(repeaterGBegin, GBeginValues);
            bindData(repeaterGEnd, GEndValues);

            bindData(repeaterSBegin, SBeginValues);
            bindData(repeaterSEnd, SEndValues);

            bindData(repeaterVBegin, VBeginValues);
            bindData(repeaterVEnd, VEndValues);

            bindData(repeaterZBegin, ZBeginValues);
            bindData(repeaterZEnd, ZEndValues);

        }

        private void bindData(Repeater repeater, List<String> lijst)
        {
            repeater.DataSource = lijst;
            repeater.DataBind();
        }

        private void readDataTable(DataTable data, List<String> begin, List<String> end)
        {
            foreach (DataRow row in data.Rows)
            {
                String word = row["woord"].ToString();
                String soortWoord = row["soortWoord"].ToString();
                if (soortWoord == "begin")
                {
                    begin.Add(word);
                }
                else if (soortWoord == "eind")
                {
                    end.Add(word);
                }
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