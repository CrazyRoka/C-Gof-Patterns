using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class CoffeeDecorator : ICoffee
    {
        private ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee) => _coffee = coffee;

        public virtual double GetCost() => _coffee.GetCost();
    }
}
