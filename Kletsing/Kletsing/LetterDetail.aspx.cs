using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kletsing.Controllers;
using System.Data;


namespace Kletsing
{
    public partial class LetterDetail : System.Web.UI.Page
    {
        DBController db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DBController();

            //List<string> beginTestValues = new List<string>();
            //List<string> midTestValues = new List<string>();
            //List<string> endTestValues = new List<string>();

            List<string> beginValues = new List<string>();
            List<string> midValues = new List<string>();
            List<string> endValues = new List<string>();

            string chosen_letter = "";
            var id = Request.QueryString["id"];
            if (id != null)
            {
                int idInt = Convert.ToInt32(id);
                switch (idInt)
                {
                    case 1:
                        chosen_letter = "A";
                        break;
                    case 2:
                        chosen_letter = "B";
                        break;
                    case 3:
                        chosen_letter = "C";
                        break;
                    case 4:
                        chosen_letter = "D";
                        break;
                    case 5:
                        chosen_letter = "E";
                        break;
                    case 6:
                        chosen_letter = "F";
                        break;
                    case 7:
                        chosen_letter = "G";
                        break;
                    case 8:
                        chosen_letter = "H";
                        break;
                    case 9:
                        chosen_letter = "I";
                        break;
                    case 10:
                        chosen_letter = "J";
                        break;
                    case 11:
                        chosen_letter = "K";
                        break;
                    case 12:
                        chosen_letter = "L";
                        break;
                    case 13:
                        chosen_letter = "M";
                        break;
                    case 14:
                        chosen_letter = "N";
                        break;
                    case 15:
                        chosen_letter = "O";
                        break;
                    case 16:
                        chosen_letter = "P";
                        break;
                    case 17:
                        chosen_letter = "R";
                        break;
                    case 18:
                        chosen_letter = "S";
                        break;
                    case 19:
                        chosen_letter = "T";
                        break;
                    case 20:
                        chosen_letter = "U";
                        break;
                    case 21:
                        chosen_letter = "V";
                        break;
                    case 22:
                        chosen_letter = "W";
                        break;
                    case 23:
                        chosen_letter = "Y";
                        break;
                    case 24:
                        chosen_letter = "Z";
                        break;
                }

                ////Create Test Data
                //for (int i = 0; i < 10; i++)
                //{
                //    //beginTestValues.Add(RandomString.createRandomString(4, 1, chosen_letter));
                //    midTestValues.Add(RandomString.createRandomString(4, 2, chosen_letter));
                //    endTestValues.Add(RandomString.createRandomString(4, 3, chosen_letter));
                //}

                //beginTestValues.Add("Stip");
                //beginTestValues.Add("Stoel");
                //beginTestValues.Add("Stok");

                ////Sort the lists
                //beginTestValues.Sort();
                //midTestValues.Sort();
                //endTestValues.Sort();

                ////Bind data to repeater
                //repeaterBegin.DataSource = beginTestValues;
                //repeaterBegin.DataBind();

                //repeaterMid.DataSource = midTestValues;
                //repeaterMid.DataBind();

                //repeaterEnd.DataSource = endTestValues;
                //repeaterEnd.DataBind();

                //TODO Zoek in database naar woorden met de letter "chosen_letter" verdeeld in 3 cat.
                DataTable data = db.GetWords(chosen_letter);
                foreach(DataRow row in data.Rows)
                {
                    String woord = row["woord"].ToString();
                    String categorie = row["categorie"].ToString();
                    String soortWoord = row["soortWoord"].ToString();

                    woord = char.ToUpper(woord[0]) + woord.Substring(1);

                    if(soortWoord == "begin")
                    {
                        beginValues.Add(woord);
                    }
                    else if(soortWoord == "midden")
                    {
                        midValues.Add(woord);
                    }
                    else if(soortWoord == "eind")
                    {
                        endValues.Add(woord);
                    }
                }

                //Bind data to repeater
                repeaterBegin.DataSource = beginValues;
                repeaterBegin.DataBind();

                repeaterMid.DataSource = midValues;
                repeaterMid.DataBind();

                repeaterEnd.DataSource = endValues;
                repeaterEnd.DataBind();


                lblChosen_letter.Text = "Gekozen letter: " + chosen_letter;
                lblChosen_letterBegin.Text = chosen_letter + " -";
                lblChosen_letterMid.Text = "- " + chosen_letter.ToLower() + " - ";
                lblChosen_letterEnd.Text = "- " + chosen_letter.ToLower();
            }
            else
            {
                Response.Redirect("Letters.aspx");
            }
        }
        public void linkbtnWord_Click(object sender, CommandEventArgs e)
        {
            db = null;
            string url = "LiedPagina.aspx?woord=" + e.CommandArgument;
            Response.Redirect(url);
        }
    }
}