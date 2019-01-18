using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class LiquidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Transform water state from liquid to solid");
            water.State = new SolidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Transform water state from liquid to gas");
            water.State = new GasWaterState();
        }
    }
}
