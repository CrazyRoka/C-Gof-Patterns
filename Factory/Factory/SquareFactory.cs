using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class SquareFactory : ShapeFactory
    {
        public IShape GetShape(double size) => new Square(size);
    }
}
