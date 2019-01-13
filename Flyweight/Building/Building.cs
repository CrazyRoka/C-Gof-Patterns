using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    class Building : IBuilding
    {
        public string Name { get; }
        public Building(string name)
        {
            Name = name;
            Console.WriteLine($"Created building with name {name}");
        }

        public void Build(double latitude, double longitude) =>
            Console.WriteLine($"Builded {Name} on location {latitude} {longitude}");
    }
}
