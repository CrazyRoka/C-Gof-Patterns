using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Programmer : Employee
    {
        public Programmer(string name) : base(name, 15000, 15)
        {
        }
    }
}
