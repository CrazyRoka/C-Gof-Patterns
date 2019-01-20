using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Director : Employee
    {
        public Director(string name) : base(name, 25000, 20)
        {
        }
    }
}
