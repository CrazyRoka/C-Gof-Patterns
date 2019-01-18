using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            water.Frost();
            water.Frost();
            water.Heat();
            water.Heat();
            water.Heat();
        }
    }
}
