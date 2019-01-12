using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class GamingComputerBuilder : ComputerBuilder
    {
        public override void SetCpu() => Computer.Cpu = "Core i9 8500";
        public override void SetRam() => Computer.Ram = "64 GB";
        public override void SetResolution() => Computer.Resolution = "4K";
        public override void SetSsd() => Computer.Ssd = "1 TB";
    }
}
