namespace MassImgToPDF
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menu_barSettings = new ToolStripMenuItem();
            menu_barQuit = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menu_barVersion = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            selectedFilesView = new ListBox();
            convertButton = new Button();
            openFilesButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(678, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu_barSettings, menu_barQuit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // menu_barSettings
            // 
            menu_barSettings.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menu_barSettings.Name = "menu_barSettings";
            menu_barSettings.Size = new Size(178, 34);
            menu_barSettings.Text = "Settings";
            menu_barSettings.Click += menu_barSettings_Click;
            // 
            // menu_barQuit
            // 
            menu_barQuit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menu_barQuit.Name = "menu_barQuit";
            menu_barQuit.Size = new Size(178, 34);
            menu_barQuit.Text = "Quit";
            menu_barQuit.Click += menu_barQuit_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu_barVersion });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(65, 29);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // menu_barVersion
            // 
            menu_barVersion.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menu_barVersion.Name = "menu_barVersion";
            menu_barVersion.Size = new Size(172, 34);
            menu_barVersion.Text = "Version";
            menu_barVersion.Click += menu_barVersion_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selectedFilesView);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 393);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Image List View";
            // 
            // selectedFilesView
            // 
            selectedFilesView.BorderStyle = BorderStyle.FixedSingle;
            selectedFilesView.FormattingEnabled = true;
            selectedFilesView.ItemHeight = 25;
            selectedFilesView.Location = new Point(6, 30);
            selectedFilesView.Name = "selectedFilesView";
            selectedFilesView.Size = new Size(533, 352);
            selectedFilesView.TabIndex = 0;
            selectedFilesView.TabStop = false;
            selectedFilesView.UseTabStops = false;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(554, 299);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(112, 97);
            convertButton.TabIndex = 2;
            convertButton.TabStop = false;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            // 
            // openFilesButton
            // 
            openFilesButton.Image = (Image)resources.GetObject("openFilesButton.Image");
            openFilesButton.Location = new Point(554, 259);
            openFilesButton.Name = "openFilesButton";
            openFilesButton.Size = new Size(112, 34);
            openFilesButton.TabIndex = 3;
            openFilesButton.TabStop = false;
            openFilesButton.Text = "Open";
            openFilesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            openFilesButton.UseVisualStyleBackColor = true;
            openFilesButton.Click += openFilesButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg";
            openFileDialog1.Multiselect = true;
            // 
            // mainPanel
            // 
            mainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainPanel.Controls.Add(openFilesButton);
            mainPanel.Controls.Add(groupBox1);
            mainPanel.Controls.Add(convertButton);
            mainPanel.Location = new Point(0, 36);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(678, 408);
            mainPanel.TabIndex = 4;
            // 
            // mainWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(678, 444);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "mainWindow";
            Text = "Mass Image to PDF Converter";
            Load += mainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem menu_barSettings;
        private ToolStripMenuItem menu_barQuit;
        private ToolStripMenuItem menu_barVersion;
        private GroupBox groupBox1;
        private Button convertButton;
        private Button openFilesButton;
        private ListBox selectedFilesView;
        private OpenFileDialog openFileDialog1;
        private Panel mainPanel;
    }
}