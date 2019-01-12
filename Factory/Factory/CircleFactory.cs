using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class CircleFactory : ShapeFactory
    {
        public IShape GetShape(double radius) => new Circle(radius);
    }
}
