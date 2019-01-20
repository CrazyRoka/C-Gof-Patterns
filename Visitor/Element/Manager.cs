using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Manager : Employee
    {
        public Manager(string name) : base(name, 10000, 10)
        {
        }
    }
}
