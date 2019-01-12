using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Circle : IShape
    {
        private double _radius;
        public Circle(double radius) => _radius = radius;

        public double GetArea() => _radius * _radius * Math.PI;
    }
}
