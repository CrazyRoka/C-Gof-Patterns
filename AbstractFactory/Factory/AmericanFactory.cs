using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class AmericanFactory : AbstractFactory
    {
        public ICar GetCar() => new AmericanCar();
        public ICompany GetCompany() => new Google();
    }
}
