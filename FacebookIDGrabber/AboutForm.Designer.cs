
namespace FacebookIDGrabber
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.LabelWebsiteLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabelWebsiteLink
            // 
            this.LabelWebsiteLink.AutoSize = true;
            this.LabelWebsiteLink.BackColor = System.Drawing.Color.Transparent;
            this.LabelWebsiteLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelWebsiteLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWebsiteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LabelWebsiteLink.LinkColor = System.Drawing.Color.White;
            this.LabelWebsiteLink.Location = new System.Drawing.Point(813, 0);
            this.LabelWebsiteLink.Name = "LabelWebsiteLink";
            this.LabelWebsiteLink.Size = new System.Drawing.Size(171, 31);
            this.LabelWebsiteLink.TabIndex = 0;
            this.LabelWebsiteLink.TabStop = true;
            this.LabelWebsiteLink.Text = "Visit Website";
            this.LabelWebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelWebsiteLink_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.LabelWebsiteLink);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Facebook ID Grabber";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LabelWebsiteLink;
    }
}