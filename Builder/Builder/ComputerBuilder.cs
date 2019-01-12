using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    abstract class ComputerBuilder
    {
        protected Computer Computer { get; private set; }
        public ComputerBuilder() => Computer = new Computer();
        public Computer GetComputer() => Computer;

        public abstract void SetCpu();
        public abstract void SetRam();
        public abstract void SetResolution();
        public abstract void SetSsd();
    }
}
