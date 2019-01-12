using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class Seller
    {
        private ComputerBuilder _computerBuilder;
        public void SetSeller(ComputerBuilder builder) => _computerBuilder = builder;
        public Computer GetComputer() => _computerBuilder.GetComputer();
        public void ConstructComputer()
        {
            _computerBuilder.SetCpu();
            _computerBuilder.SetRam();
            _computerBuilder.SetResolution();
            _computerBuilder.SetSsd();
        }
    }
}
