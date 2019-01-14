using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class Squirrel : AbstractHandler
    {
        public override void Handle(object food)
        {
            if(food as string == "nut")
            {
                Console.WriteLine("Squirrel will eat nut");
            }
            else
            {
                Console.WriteLine($"Squirrel will not eat {food}");
                base.Handle(food);
            }
        }
    }
}
