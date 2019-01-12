using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Car : ITransport
    {
        public void Drive() => Console.WriteLine("Drive on the road");
    }
}
