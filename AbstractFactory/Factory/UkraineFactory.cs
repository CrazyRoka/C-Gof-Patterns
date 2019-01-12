using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class UkraineFactory : AbstractFactory
    {
        public ICar GetCar() => new UkraineCar();
        public ICompany GetCompany() => new SoftServe();
    }
}
