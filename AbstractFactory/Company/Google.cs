using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Google : ICompany
    {
        public string Name { get; }
        public Google() => Name = "Google";
    }
}
