using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D04TestingLibrary;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace D04Libraries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //Person person = new Person();

            //C# access modifires 

            string city = "Warsaw";
            WeatherManager weatherManager = new WeatherManager();
            double temp1 = weatherManager.GetTemperature("Warsaw");
            double temp2 = weatherManager.GetTemperature("Singapore");

            Console.WriteLine(temp1);
            Console.WriteLine(temp2);




            /// <summary>
            /// This sample is the obligatory Hello World program.
            /// </summary>


            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString($"Today in {city} we have temperature {temp1}", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.Center);

            // Save the document...
            const string filename = "HelloWorld.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);

            Console.ReadKey();

        }
    }
}