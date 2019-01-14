using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class Monkey : AbstractHandler
    {
        public override void Handle(object food)
        {
            if(food as string == "banana")
            {
                Console.WriteLine("Monkey will eat banana");
            }
            else
            {
                Console.WriteLine($"Monkey will not eat {food}");
                base.Handle(food);
            }
        }
    }
}
