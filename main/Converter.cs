//using System;
//using System.Collections.Generic;
//using Microsoft.Extensions.Configuration;
//using MassImgToPDF;
using MassImgToPDF.main.settings;
//using iText;
using iText.Kernel.Pdf;
using iText.Layout;
//using iText.Layout.Element;
using iText.IO.Image;
//using System.Diagnostics;

namespace MassImgToPDF.main
{
    internal static class Converter
    {
        public static string[] imgFiles = { };
        public static List<string> imgFileShortNames = new List<string>();

        public static void ConvertToPDF()
        {
            for (int i = 0; i < imgFiles.Length; i++)
            {
                PdfWriter writer = new PdfWriter(SettingsIO.outputPath + @"\" + Path.GetFileNameWithoutExtension(imgFileShortNames[i]) + ".pdf");
                PdfDocument pdfDocument = new PdfDocument(writer);
                Document document = new Document(pdfDocument);
                iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(imgFiles[i]));
                document.Add(image);

                document.Close();
                pdfDocument.Close();
                writer.Close();
            }
        }
    }
}
