using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DataExporter pdfExporter = new PdfDataExporter();
            pdfExporter.ExportFormattedData();

            DataExporter xmlExporter = new XmlDataExporter();
            xmlExporter.ExportFormattedData();
        }
    }
}
