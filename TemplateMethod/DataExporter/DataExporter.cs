using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class DataExporter
    {
        public virtual void ReadData()
        {
            Console.WriteLine("Reading data");
        }

        public virtual void FormatData()
        {
            Console.WriteLine("Formatting data");
        }

        public abstract void ExportData();

        public void ExportFormattedData()
        {
            ReadData();
            FormatData();
            ExportData();
        }
    }
}
