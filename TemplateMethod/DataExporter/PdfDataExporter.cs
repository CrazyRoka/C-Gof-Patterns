using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class PdfDataExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting as pdf");
        }
    }
}
