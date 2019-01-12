using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    interface AbstractFactory
    {
        ICar GetCar();
        ICompany GetCompany();
    }
}
