using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override object Clone()
        {
            Console.WriteLine($"Cloning color: {_red:D3},{_green:D3},{_blue:D3}");
            return this.MemberwiseClone();
        }
    }
}
