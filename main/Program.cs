using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;
using System.Diagnostics;
using MassImgToPDF.main.settings;

namespace MassImgToPDF.main
{
    internal static class Program
    {
        public enum programStatus
        {
            Idle,
            Busy,
            Done
        }

        [STAThread]
        static void Main()
        {
            SettingsIO.loadSettings();
            ApplicationConfiguration.Initialize();
            Application.Run(new mainWindow());
        }
    }
}