using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;
using System.Diagnostics;
using MassImgToPDF.settings;

namespace MassImgToPDF
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            settingsIO.loadSettings();
            ApplicationConfiguration.Initialize();
            Application.Run(new mainWindow());
        }
    }
}