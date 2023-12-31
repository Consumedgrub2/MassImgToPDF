//using System;
//using System.Collections.Generic;
//using System.IO;
using System.Timers;
//using Microsoft.Extensions.Configuration;
//using MassImgToPDF;
using MassImgToPDF.main;
//using System.Diagnostics;
//using System.Reflection.Metadata.Ecma335;

namespace MassImgToPDF
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "Status: " + Program.programStatus.Idle.ToString();
        }

        private void openFilesButton_Click(object sender, EventArgs e)
        {
            selectedFilesView.Items.Clear();
            selectedFilesView.Refresh();
            Converter.imgFiles = new string[] { };
            Converter.imgFileShortNames.Clear();

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Converter.imgFiles = openFileDialog1.FileNames;

                foreach (string imgFile in Converter.imgFiles)
                {
                    DirectoryInfo imgDir = new DirectoryInfo(imgFile);
                    Converter.imgFileShortNames.Add(imgDir.Name);
                    selectedFilesView.Items.Add(imgDir.Name);
                }
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (Converter.imgFiles.Length == 0)
            {
                MessageBox.Show("No files selected!", "MassImgToPDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                statusLabel.Text = "Status: " + Program.programStatus.Busy.ToString();
                Converter.ConvertToPDF();
                statusLabel.Text = "Status: " + Program.programStatus.Done.ToString();

                System.Timers.Timer timer = new System.Timers.Timer(5000);

                timer.Elapsed += SetStatusToIdle;
                timer.Start();
            }
        }

        public void SetStatusToIdle(object? sender, ElapsedEventArgs e)
        {
            statusLabel.Invoke((MethodInvoker)(() =>
            {
                statusLabel.Text = "Status: " + Program.programStatus.Idle.ToString();
            }));
        }

        private void menu_barVersion_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWin = new AboutWindow();
            aboutWin.ShowDialog();
        }

        private void menu_barSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWin = new SettingsWindow();
            settingsWin.ShowDialog();
        }

        private void menu_barQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}