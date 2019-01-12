using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Square : IShape
    {
        private double _size;
        public Square(double size) => _size = size;

        public double GetArea() => _size * _size;
    }
}
