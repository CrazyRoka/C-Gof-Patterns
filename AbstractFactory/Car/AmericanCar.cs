using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class AmericanCar : ICar
    {
        public string Name { get; }
        public AmericanCar() => Name = "Chevrolet";
    }
}
