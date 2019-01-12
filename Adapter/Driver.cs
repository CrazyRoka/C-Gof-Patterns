using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
