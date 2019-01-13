using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Expresso : ICoffee
    {
        public double GetCost()
        {
            return 12.5;
        }
    }
}
