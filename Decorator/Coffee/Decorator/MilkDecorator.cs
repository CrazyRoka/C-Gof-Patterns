using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost() => base.GetCost() + 5.5;
    }
}
