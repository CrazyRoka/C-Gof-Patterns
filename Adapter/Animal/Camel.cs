using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Camel : IAnimal
    {
        public void Move() => Console.WriteLine("Ride on the desert");
    }
}
