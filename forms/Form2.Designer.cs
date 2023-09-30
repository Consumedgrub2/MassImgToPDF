namespace MassImgToPDF
{
    partial class aboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutWindow));
            programTitle = new Label();
            versionTitle = new Label();
            aboutPanel = new Panel();
            copyright = new Label();
            logo = new PictureBox();
            aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // programTitle
            // 
            programTitle.AutoSize = true;
            programTitle.Location = new Point(29, 145);
            programTitle.Name = "programTitle";
            programTitle.Size = new Size(250, 25);
            programTitle.TabIndex = 0;
            programTitle.Text = "Mass Image To PDF Converter";
            // 
            // versionTitle
            // 
            versionTitle.AutoSize = true;
            versionTitle.Location = new Point(134, 190);
            versionTitle.Name = "versionTitle";
            versionTitle.Size = new Size(45, 25);
            versionTitle.TabIndex = 1;
            versionTitle.Text = "v0.1";
            // 
            // aboutPanel
            // 
            aboutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            aboutPanel.Controls.Add(copyright);
            aboutPanel.Controls.Add(logo);
            aboutPanel.Controls.Add(programTitle);
            aboutPanel.Controls.Add(versionTitle);
            aboutPanel.Location = new Point(0, 0);
            aboutPanel.Name = "aboutPanel";
            aboutPanel.Size = new Size(319, 228);
            aboutPanel.TabIndex = 2;
            // 
            // copyright
            // 
            copyright.AutoSize = true;
            copyright.Location = new Point(20, 170);
            copyright.Name = "copyright";
            copyright.Size = new Size(277, 25);
            copyright.TabIndex = 3;
            copyright.Text = "Copyright © 2023 Michael Maher";
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.Location = new Point(91, 14);
            logo.Name = "logo";
            logo.Size = new Size(130, 128);
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // aboutWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(318, 224);
            Controls.Add(aboutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(340, 280);
            MinimizeBox = false;
            MinimumSize = new Size(340, 280);
            Name = "aboutWindow";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            TopMost = true;
            aboutPanel.ResumeLayout(false);
            aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label programTitle;
        private Label versionTitle;
        private Panel aboutPanel;
        private PictureBox logo;
        private Label copyright;
    }
}