using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class XmlDataExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting as xml");
        }
    }
}
