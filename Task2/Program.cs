using System;
using System.IO;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace Task2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());


            // Customers and Account Report

            //Controller controller = new Controller();
            //controller.ReadBinaryData();
            //string xmlFilePath = "customer_report.xml";
            //controller.GenerateXmlReport(xmlFilePath);
            //Console.WriteLine("XML report generated successfully.");
        }

    }
}