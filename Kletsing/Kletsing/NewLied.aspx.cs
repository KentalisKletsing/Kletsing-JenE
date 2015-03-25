using Kletsing.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kletsing
{
    public partial class NewLied : System.Web.UI.Page
    {
        DBController database = new DBController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            string songFileName;
            string videoFileName;
            string lessonFileName;

            if (SongUploadControl.HasFile)
            {
                try
                {
                    //Only MP3 audio
                    if (SongUploadControl.PostedFile.ContentType == "audio/mp3")
                    {
                        //Allow up to 20 MB
                        if (SongUploadControl.PostedFile.ContentLength < 20971520)
                        {
                            songFileName = Path.GetFileName(SongUploadControl.FileName);
                            SongUploadControl.SaveAs(Server.MapPath("~/uploads/") + songFileName);
                            StatusLabel1.Text = "Upload status: File geüpload!";
                        }
                        else
                        {
                            StatusLabel1.Text = "Upload status: Het bestand moet kleiner zijn dan 20MB!";
                        }
                    }
                    else
                    {
                        StatusLabel1.Text = "Upload status: Alleen MP3 bestanden zijn toegestaan!";
                    }
                }
                catch (Exception ex)
                {
                    StatusLabel1.Text = "Upload status: Het bestand kon niet worden geüpload door de volgende fout: " + ex.Message;
                }
            }
            if (VideoUploadControl.HasFile)
            {
                try
                {
                    //Only MP4 video
                    if (VideoUploadControl.PostedFile.ContentType == "video/mp4")
                    {
                        //Allow up to 20 MB
                        if (VideoUploadControl.PostedFile.ContentLength < 20971520)
                        {
                            videoFileName = Path.GetFileName(VideoUploadControl.FileName);
                            VideoUploadControl.SaveAs(Server.MapPath("~/uploads/") + videoFileName);
                            StatusLabel2.Text = "Upload status: File geüpload!";
                        }
                        else
                        {
                            StatusLabel2.Text = "Upload status: Het bestand moet kleiner zijn dan 20MB!";
                        }
                    }
                    else
                    {
                        StatusLabel2.Text = "Upload status: Alleen MP4 bestanden zijn toegestaan!";
                    }
                }
                catch (Exception ex)
                {
                    StatusLabel2.Text = "Upload status: Het bestand kon niet worden geüpload door de volgende fout: " + ex.Message;
                }
            }
            if (LessonUploadControl.HasFile)
            {
                try
                {
                    //Only PDF
                    if (LessonUploadControl.PostedFile.ContentType == "application/pdf")
                    {
                        //Allow up to 20 MB
                        if (LessonUploadControl.PostedFile.ContentLength < 20971520)
                        {
                            lessonFileName = Path.GetFileName(SongUploadControl.FileName);
                            LessonUploadControl.SaveAs(Server.MapPath("~/uploads/") + lessonFileName);
                            StatusLabel3.Text = "Upload status: File geüpload!";
                        }
                        else
                        {
                            StatusLabel3.Text = "Upload status: Het bestand moet kleiner zijn dan 20MB!";
                        }
                    }
                    else
                    {
                        StatusLabel3.Text = "Upload status: Alleen PDF bestanden zijn toegestaan!";
                    }
                }
                catch (Exception ex)
                {
                    StatusLabel3.Text = "Upload status: Het bestand kon niet worden geüpload door de volgende fout: " + ex.Message;
                }
            }

            char[] delimiters = {';'};
            string[] words = WoordenTextBox.Text.Split(delimiters);
            foreach (string s in words)
            {
                database.AddWord(s, s.Substring(0, 1), "begin");
            }
        }
    }
}