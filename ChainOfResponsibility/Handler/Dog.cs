using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class Dog : AbstractHandler
    {
        public override void Handle(object food)
        {
            if(food as string == "bone")
            {
                Console.WriteLine("Dog will eat bone");
            }
            else
            {
                Console.WriteLine($"Dog will not eat {food}");
                base.Handle(food);
            }
        }
    }
}
