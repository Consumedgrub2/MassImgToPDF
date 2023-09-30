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
            programTitle = new Label();
            versionTitle = new Label();
            SuspendLayout();
            // 
            // programTitle
            // 
            programTitle.AutoSize = true;
            programTitle.Location = new Point(35, 130);
            programTitle.Name = "programTitle";
            programTitle.Size = new Size(250, 25);
            programTitle.TabIndex = 0;
            programTitle.Text = "Mass Image To PDF Converter";
            // 
            // versionTitle
            // 
            versionTitle.AutoSize = true;
            versionTitle.Location = new Point(130, 160);
            versionTitle.Name = "versionTitle";
            versionTitle.Size = new Size(45, 25);
            versionTitle.TabIndex = 1;
            versionTitle.Text = "v0.1";
            // 
            // aboutWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(318, 204);
            Controls.Add(versionTitle);
            Controls.Add(programTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(340, 260);
            MinimizeBox = false;
            MinimumSize = new Size(340, 260);
            Name = "aboutWindow";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label programTitle;
        private Label versionTitle;
    }
}