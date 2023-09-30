using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;
using System.Diagnostics;
using Microsoft.Extensions.FileProviders;

namespace MassImgToPDF.main.settings
{
    internal static class settingsIO
    {
        //Main variables
        private static string configDirectoryPath = "";
        private static string configPath = "";

        //Settings variables
        public static string outputPath = "";

        public static void loadSettings()
        {
            configDirectoryPath = Directory.GetCurrentDirectory() + @"\config";
            configPath = configDirectoryPath + @"\config.ini";

            string[] config = new string[]
            {
                    "[AppSettings]",
                    "outputPath=" + Environment.ProcessPath + @"\PDFOutput"
            };

            if (!Path.Exists(configDirectoryPath))
            {
                Directory.CreateDirectory(configDirectoryPath);
                File.WriteAllLines(configPath, config);
            }
            else if (!File.Exists(configPath))
            {
                File.WriteAllLines(configPath, config);
            }

            //Build file into interpreted ini file

            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddIniFile(configPath);

            IConfigurationRoot configurationRoot = configurationBuilder.Build();

            outputPath = configurationRoot["AppSettings:outputPath"] ?? Directory.GetCurrentDirectory();
        }

        public static void writeSettings()
        {
            //Write in-memory settings
            outputPath = settingsWindow.currentOutputPathTextBoxText;

            //Write to storage
            string[] config = new string[]
            {
                    "[AppSettings]",
                    "outputPath=" + outputPath
            };

            if (!Path.Exists(configDirectoryPath))
            {
                Directory.CreateDirectory(configDirectoryPath);
            }

            File.WriteAllLines(configPath, config);
        }
    }
}
