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
            // When "Copy URL" button is clicked, attempt to copy text in URL field to clipboard. If no text present, catch exception. Update status strip accordingly.
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

            // TODO: Check if provided URL is a valid Facebook URL.
            // TODO: Check if provided URL is a mobile Facebook URL. If so, skip to calling GetPageIdMobile method.
            try
            {
                // Grab page source and store in variable.
                HtmlAgilityPack.HtmlDocument doc = web.Load(pageUrl);
                pageSource = doc.Text;

                // Search page source for page ID matches using regular expression.
                Regex rx = new Regex(@"""(pageID|entity_id)"":""(\d+)""", RegexOptions.Compiled);
                MatchCollection matches = rx.Matches(pageSource);

                try
                {
                    // Check for successful match and store in variable if present.
                    pageId = matches[0].Groups[2].Value;
                    StatusStripLabel.Text = "Page ID found";
                }
                catch (ArgumentOutOfRangeException)
                {
                    // If no match found, call method to check for the page ID using the mobile URL.
                    try
                    {
                        pageId = GetPageIdMobile(pageUrlMobile);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        StatusStripLabel.Text = "No page ID found";
                    }
                }
            }
            catch (UriFormatException)
            {
                StatusStripLabel.Text = "Invalid URL provided";
            }
            catch (System.Net.WebException)
            {
                StatusStripLabel.Text = "No page ID found";
            }
            return pageId;
        }

        // Failsafe for when no page ID is found using the desktop URL.
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
            // When "Copy ID" button is clicked, attempt to copy text in ID field to clipboard. If no text present, catch exception. Update status strip accordingly.
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
