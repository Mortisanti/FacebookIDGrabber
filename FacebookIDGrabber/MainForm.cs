using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace FacebookIDGrabber
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CopyURLButton_Click(object sender, EventArgs e)
        {
            // Copy text, if present. If not present, catch exception and update status strip
            try
            {
                Clipboard.SetText(FieldInput.Text);
                StatusStripLabel.Text = "URL copied";
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
                StatusStripLabel.Text = "No text to copy";
            }
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void ButtonFindID_Click(object sender, EventArgs e)
        {
            ButtonFindID.Enabled = false;
            ButtonClearFields.Enabled = false;
            StatusStripLabel.Text = "Finding Page ID...";
            string pageUrl = FieldInput.Text;
            string pageUrlMobile = FieldInput.Text.Replace("www", "m");
            FieldOutput.Text = await Task.Run(() => GetPageId(pageUrl, pageUrlMobile));
            ButtonFindID.Enabled = true;
            ButtonClearFields.Enabled = true;
        }

        
        private string GetPageId(string pageUrl, string pageUrlMobile)
        {
            string pageSource;
            string pageId = null;

            HtmlWeb web = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };

            try
            {
                HtmlAgilityPack.HtmlDocument doc = web.Load(pageUrl);
                pageSource = doc.Text;

                Regex rx = new Regex(@"""(pageID|entity_id)"":""(\d+)""", RegexOptions.Compiled);
                MatchCollection matches = rx.Matches(pageSource);

                try
                { 
                    pageId = matches[0].Groups[2].Value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    try
                    {
                        pageId = GetPageIdMobile(pageUrlMobile);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        StatusStripLabel.Text = "No page ID found";
                    }
                }

                StatusStripLabel.Text = "Page ID found";
            }
            catch (UriFormatException)
            {
                StatusStripLabel.Text = "Invalid URL provided";
            }
            catch (System.Net.WebException)
            {
                StatusStripLabel.Text = "No page ID found";
            }
            /*
            finally
            {
                ButtonFindID.Enabled = true;
                ButtonClearFields.Enabled = true;
            }
            */

            return pageId;
        }

        
        private string GetPageIdMobile(string pageUrlMobile)
        {
            StatusStripLabel.Text = "First check for ID failed. Trying mobile version...";
            string pageSource;
            string pageId;

            HtmlWeb web = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };

            HtmlAgilityPack.HtmlDocument doc = web.Load(pageUrlMobile);
            pageSource = doc.Text;

            Regex rx = new Regex(@"rid=(\d+)", RegexOptions.Compiled);
            MatchCollection matches = rx.Matches(pageSource);

            pageId = matches[0].Groups[1].Value;

            return pageId;
        }
   
        private void FieldInput_TextChanged(object sender, EventArgs e)
        {
            if (FieldInput.Text != "")
            {
                ButtonFindID.Enabled = true;
            }
            else
            {
                ButtonFindID.Enabled = false;
            }
        }

        private void FieldOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCopyID_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(FieldOutput.Text);
                StatusStripLabel.Text = "ID copied to clipboard";
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
                StatusStripLabel.Text = "Failed: no text to copy";
            }
        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            FieldInput.Text = "";
            FieldOutput.Text = "";
            StatusStripLabel.Text = "Text fields cleared";
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
