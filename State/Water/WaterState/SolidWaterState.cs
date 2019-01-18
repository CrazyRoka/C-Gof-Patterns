using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Transform water state from solid to liquid");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Do not change solid water state");
        }
    }
}
