namespace MassImgToPDF
{
    partial class settingsWindow
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
            settingsBox1 = new GroupBox();
            chooseOutputPathButton = new Button();
            outputPathTextBox = new TextBox();
            okSettingsButton = new Button();
            cancelSettingsButton = new Button();
            applySettingsButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            settingsBox1.SuspendLayout();
            SuspendLayout();
            // 
            // settingsBox1
            // 
            settingsBox1.Controls.Add(chooseOutputPathButton);
            settingsBox1.Controls.Add(outputPathTextBox);
            settingsBox1.Location = new Point(12, 12);
            settingsBox1.Name = "settingsBox1";
            settingsBox1.Size = new Size(654, 78);
            settingsBox1.TabIndex = 0;
            settingsBox1.TabStop = false;
            settingsBox1.Text = "Output Path";
            // 
            // chooseOutputPathButton
            // 
            chooseOutputPathButton.Location = new Point(536, 30);
            chooseOutputPathButton.Name = "chooseOutputPathButton";
            chooseOutputPathButton.Size = new Size(112, 34);
            chooseOutputPathButton.TabIndex = 0;
            chooseOutputPathButton.TabStop = false;
            chooseOutputPathButton.Text = "...";
            chooseOutputPathButton.UseVisualStyleBackColor = true;
            chooseOutputPathButton.Click += chooseOutputPathButton_Click;
            // 
            // outputPathTextBox
            // 
            outputPathTextBox.Location = new Point(6, 32);
            outputPathTextBox.Name = "outputPathTextBox";
            outputPathTextBox.Size = new Size(524, 31);
            outputPathTextBox.TabIndex = 0;
            outputPathTextBox.TextChanged += outputPathTextBox_TextChanged;
            // 
            // okSettingsButton
            // 
            okSettingsButton.Location = new Point(318, 118);
            okSettingsButton.Name = "okSettingsButton";
            okSettingsButton.Size = new Size(112, 34);
            okSettingsButton.TabIndex = 1;
            okSettingsButton.TabStop = false;
            okSettingsButton.Text = "OK";
            okSettingsButton.UseVisualStyleBackColor = true;
            okSettingsButton.Click += okSettingsButton_Click;
            // 
            // cancelSettingsButton
            // 
            cancelSettingsButton.Location = new Point(436, 118);
            cancelSettingsButton.Name = "cancelSettingsButton";
            cancelSettingsButton.Size = new Size(112, 34);
            cancelSettingsButton.TabIndex = 2;
            cancelSettingsButton.TabStop = false;
            cancelSettingsButton.Text = "Cancel";
            cancelSettingsButton.UseVisualStyleBackColor = true;
            cancelSettingsButton.Click += cancelSettingsButton_Click;
            // 
            // applySettingsButton
            // 
            applySettingsButton.Enabled = false;
            applySettingsButton.Location = new Point(554, 118);
            applySettingsButton.Name = "applySettingsButton";
            applySettingsButton.Size = new Size(112, 34);
            applySettingsButton.TabIndex = 3;
            applySettingsButton.TabStop = false;
            applySettingsButton.Text = "Apply";
            applySettingsButton.UseVisualStyleBackColor = true;
            applySettingsButton.Click += applySettingsButton_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // settingsWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(678, 164);
            Controls.Add(applySettingsButton);
            Controls.Add(cancelSettingsButton);
            Controls.Add(okSettingsButton);
            Controls.Add(settingsBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(700, 220);
            MinimizeBox = false;
            MinimumSize = new Size(700, 220);
            Name = "settingsWindow";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            TopMost = true;
            settingsBox1.ResumeLayout(false);
            settingsBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox settingsBox1;
        private Button chooseOutputPathButton;
        private TextBox outputPathTextBox;
        private Button okSettingsButton;
        private Button cancelSettingsButton;
        private Button applySettingsButton;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}