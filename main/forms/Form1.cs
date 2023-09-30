using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MassImgToPDF;
using iText;
using iText.Kernel.Pdf;

namespace MassImgToPDF
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void openFilesButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void menu_barVersion_Click(object sender, EventArgs e)
        {
            aboutWindow aboutWin = new aboutWindow();
            aboutWin.ShowDialog();
        }

        private void menu_barSettings_Click(object sender, EventArgs e)
        {
            settingsWindow settingsWin = new settingsWindow();
            settingsWin.ShowDialog();
        }

        private void menu_barQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}