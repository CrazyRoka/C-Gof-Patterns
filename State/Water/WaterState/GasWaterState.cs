using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class GasWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Transform water state from gas to liquid");
            water.State = new LiquidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Do not change gas water state");
        }
    }
}
