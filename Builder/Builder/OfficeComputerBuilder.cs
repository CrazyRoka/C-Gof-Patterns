using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class OfficeComputerBuilder : ComputerBuilder
    {
        public override void SetCpu() => Computer.Cpu = "Core i3 8100";
        public override void SetRam() => Computer.Ram = "8 GB";
        public override void SetResolution() => Computer.Resolution = "1920x1080";
        public override void SetSsd() => Computer.Ssd = "128 GB";
    }
}
