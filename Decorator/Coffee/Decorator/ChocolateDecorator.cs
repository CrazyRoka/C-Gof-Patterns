using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost() => base.GetCost() + 3.5;
    }
}
