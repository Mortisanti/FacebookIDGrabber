
namespace FacebookIDGrabber
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LabelURL = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.FieldInput = new System.Windows.Forms.TextBox();
            this.FieldOutput = new System.Windows.Forms.TextBox();
            this.ButtonCopyURL = new System.Windows.Forms.Button();
            this.ButtonCopyID = new System.Windows.Forms.Button();
            this.ButtonFindID = new System.Windows.Forms.Button();
            this.ButtonClearFields = new System.Windows.Forms.Button();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelURL
            // 
            this.LabelURL.AutoSize = true;
            this.LabelURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LabelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelURL.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelURL.Location = new System.Drawing.Point(6, 34);
            this.LabelURL.Name = "LabelURL";
            this.LabelURL.Size = new System.Drawing.Size(158, 18);
            this.LabelURL.TabIndex = 0;
            this.LabelURL.Text = "Business Page URL";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelID.Location = new System.Drawing.Point(12, 76);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(141, 18);
            this.LabelID.TabIndex = 1;
            this.LabelID.Text = "Business Page ID";
            // 
            // FieldInput
            // 
            this.FieldInput.AutoCompleteCustomSource.AddRange(new string[] {
            "https://www.facebook.com/"});
            this.FieldInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.FieldInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FieldInput.Location = new System.Drawing.Point(170, 35);
            this.FieldInput.Name = "FieldInput";
            this.FieldInput.Size = new System.Drawing.Size(275, 20);
            this.FieldInput.TabIndex = 2;
            this.FieldInput.TextChanged += new System.EventHandler(this.FieldInput_TextChanged);
            // 
            // FieldOutput
            // 
            this.FieldOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FieldOutput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FieldOutput.Location = new System.Drawing.Point(170, 77);
            this.FieldOutput.Name = "FieldOutput";
            this.FieldOutput.Size = new System.Drawing.Size(275, 20);
            this.FieldOutput.TabIndex = 3;
            this.FieldOutput.TextChanged += new System.EventHandler(this.FieldOutput_TextChanged);
            // 
            // ButtonCopyURL
            // 
            this.ButtonCopyURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonCopyURL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCopyURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCopyURL.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCopyURL.Location = new System.Drawing.Point(451, 33);
            this.ButtonCopyURL.Name = "ButtonCopyURL";
            this.ButtonCopyURL.Size = new System.Drawing.Size(136, 23);
            this.ButtonCopyURL.TabIndex = 4;
            this.ButtonCopyURL.Text = "Copy URL";
            this.ButtonCopyURL.UseVisualStyleBackColor = false;
            this.ButtonCopyURL.Click += new System.EventHandler(this.CopyURLButton_Click);
            // 
            // ButtonCopyID
            // 
            this.ButtonCopyID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonCopyID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCopyID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCopyID.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCopyID.Location = new System.Drawing.Point(451, 75);
            this.ButtonCopyID.Name = "ButtonCopyID";
            this.ButtonCopyID.Size = new System.Drawing.Size(136, 23);
            this.ButtonCopyID.TabIndex = 7;
            this.ButtonCopyID.Text = "Copy ID";
            this.ButtonCopyID.UseVisualStyleBackColor = false;
            this.ButtonCopyID.Click += new System.EventHandler(this.ButtonCopyID_Click);
            // 
            // ButtonFindID
            // 
            this.ButtonFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonFindID.Enabled = false;
            this.ButtonFindID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonFindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFindID.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonFindID.Location = new System.Drawing.Point(170, 119);
            this.ButtonFindID.Name = "ButtonFindID";
            this.ButtonFindID.Size = new System.Drawing.Size(275, 23);
            this.ButtonFindID.TabIndex = 8;
            this.ButtonFindID.Text = "Find ID";
            this.ButtonFindID.UseVisualStyleBackColor = false;
            this.ButtonFindID.Click += new System.EventHandler(this.ButtonFindID_Click);
            // 
            // ButtonClearFields
            // 
            this.ButtonClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonClearFields.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClearFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearFields.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonClearFields.Location = new System.Drawing.Point(170, 154);
            this.ButtonClearFields.Name = "ButtonClearFields";
            this.ButtonClearFields.Size = new System.Drawing.Size(275, 23);
            this.ButtonClearFields.TabIndex = 9;
            this.ButtonClearFields.Text = "Clear Fields";
            this.ButtonClearFields.UseVisualStyleBackColor = false;
            this.ButtonClearFields.Click += new System.EventHandler(this.ButtonClearFields_Click);
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExit});
            this.MenuFile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuItemExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(93, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.MenuHelp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuItemAbout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(599, 24);
            this.MenuStrip.TabIndex = 6;
            this.MenuStrip.Text = "menuStrip";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 194);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(599, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 10;
            this.StatusStrip.Text = "Status";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(385, 17);
            this.StatusStripLabel.Text = "Enter a Facebook Business Page URL and press \"Enter\", or click \"Find ID\"";
            // 
            // MainForm
            // 
            this.AcceptButton = this.ButtonFindID;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelButton = this.ButtonClearFields;
            this.ClientSize = new System.Drawing.Size(599, 216);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ButtonClearFields);
            this.Controls.Add(this.ButtonFindID);
            this.Controls.Add(this.ButtonCopyID);
            this.Controls.Add(this.ButtonCopyURL);
            this.Controls.Add(this.FieldOutput);
            this.Controls.Add(this.FieldInput);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.LabelURL);
            this.Controls.Add(this.MenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 255);
            this.MinimumSize = new System.Drawing.Size(615, 255);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook ID Grabber";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelURL;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox FieldInput;
        private System.Windows.Forms.TextBox FieldOutput;
        private System.Windows.Forms.Button ButtonCopyURL;
        private System.Windows.Forms.Button ButtonCopyID;
        private System.Windows.Forms.Button ButtonFindID;
        private System.Windows.Forms.Button ButtonClearFields;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
    }
}

