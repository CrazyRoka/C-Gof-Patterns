using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class SoftServe : ICompany
    {
        public string Name { get; }
        public SoftServe() => Name = "SoftServe";
    }
}
