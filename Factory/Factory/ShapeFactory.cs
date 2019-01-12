using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface ShapeFactory
    {
        IShape GetShape(double size);
    }
}
