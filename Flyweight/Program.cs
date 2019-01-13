using System;

namespace FlyweightPattern
{
    class Program
    {
        static HouseFactory factory = new HouseFactory();
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                buildBuilding("Concrete", i / 10.0, i * 14.3);
            }

            for(int i = 0; i < 100; i++)
            {
                buildBuilding("Brick", i / 5.4, i * 2.3);
            }
        }

        static void buildBuilding(string name, double latitude, double longitude)
        {
            IBuilding building = factory.GetBuilding(name);
            building.Build(latitude, longitude);
        }
    }
}
