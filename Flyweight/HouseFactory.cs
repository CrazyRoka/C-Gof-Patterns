using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    class HouseFactory
    {
        Dictionary<string, IBuilding> buildings = new Dictionary<string, IBuilding>();

        public IBuilding GetBuilding(string name)
        {
            if (buildings.ContainsKey(name))
            {
                return buildings[name];
            }
            IBuilding building = new Building(name);
            buildings.Add(name, building);
            return building;
        }
    }
}
