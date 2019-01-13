using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee expresso = new Expresso();
            Console.WriteLine($"Expresso price = {expresso.GetCost()}");

            ICoffee milkCoffee = new MilkDecorator(new Expresso());
            Console.WriteLine($"Expresso with milk price = {milkCoffee.GetCost()}");

            ICoffee chocolateCoffe = new ChocolateDecorator(new Expresso());
            Console.WriteLine($"Expresso with chocolate price = {chocolateCoffe.GetCost()}");

            ICoffee tastyCoffee = new MilkDecorator(new ChocolateDecorator(new Expresso()));
            Console.WriteLine($"Expresso with milk and chocolate costs {tastyCoffee.GetCost()}");

        }
    }
}
