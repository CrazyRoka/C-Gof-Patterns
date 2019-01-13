using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    interface IBuilding
    {
        void Build(double latitude, double longitude);
    }
}
