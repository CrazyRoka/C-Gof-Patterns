using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class UkraineCar : ICar
    {
        public string Name { get; }
        public UkraineCar() => Name = "Tesla";
    }
}
