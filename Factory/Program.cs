using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UseSquare();
            UseCircle();
        }

        public static void UseSquare()
        {
            ShapeFactory factory = new SquareFactory();
            Sample(factory);
        }

        public static void UseCircle()
        {
            ShapeFactory factory = new CircleFactory();
            Sample(factory);
        }

        public static void Sample(ShapeFactory factory)
        {
            IShape shape = factory.GetShape(10);
            Console.WriteLine($"Shape area = {shape.GetArea()}");
            Console.WriteLine($"Shape is {shape.GetType().Name}");
        }
    }
}
