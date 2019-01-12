using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager manager = new ColorManager();
            manager["red"] = new Color(255, 0, 0);
            manager["green"] = new Color(0, 255, 0);
            manager["blue"] = new Color(0, 0, 255);

            ColorPrototype red = manager["red"];
            ColorPrototype green = manager["green"];
            ColorPrototype blue = manager["blue"];
        }
    }
}
