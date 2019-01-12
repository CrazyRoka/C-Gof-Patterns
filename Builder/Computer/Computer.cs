using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class Computer
    {
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Ssd { get; set; }
        public string Resolution { get; set; }
        public Computer() { }

        public override string ToString() =>
            $"Resolution: {Resolution}, " +
            $"CPU: {Cpu}, " +
            $"RAM: {Ram}, " +
            $"SDD: {Ssd}";
    }
}
