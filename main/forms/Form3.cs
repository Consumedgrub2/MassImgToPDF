//using System;
//using System.Collections.Generic;
//using Microsoft.Extensions.Configuration;
//using MassImgToPDF;
using MassImgToPDF.main.settings;

namespace MassImgToPDF
{
    public partial class SettingsWindow : Form
    {
        //Settings variables
        public static string currentOutputPathTextBoxText = "";

        public SettingsWindow()
        {
            InitializeComponent();
            outputPathTextBox.Text = SettingsIO.outputPath;
        }

        private void outputPathTextBox_TextChanged(object sender, EventArgs e)
        {
            currentOutputPathTextBoxText = outputPathTextBox.Text;
            if (outputPathTextBox.Text != SettingsIO.outputPath)
            {
                applySettingsButton.Enabled = true;
            }
            else
            {
                applySettingsButton.Enabled = false;
            }
        }

        private void chooseOutputPathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                outputPathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        public void ApplySettings()
        {
            SettingsIO.WriteSettings();
        }

        private void cancelSettingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            ApplySettings();
            applySettingsButton.Enabled = false;
        }

        private void okSettingsButton_Click(object sender, EventArgs e)
        {
            ApplySettings();
            applySettingsButton.Enabled = false;
            this.Close();
        }
    }
}
