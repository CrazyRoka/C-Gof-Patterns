using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Squirrel squirrel = new Squirrel();
            Monkey monkey = new Monkey();
            Dog dog = new Dog();

            squirrel.SetSuccessor(monkey).SetSuccessor(dog);

            squirrel.Handle("banana");
            Console.WriteLine();
            squirrel.Handle("nut");
            Console.WriteLine();
            squirrel.Handle("bone");
            Console.WriteLine();
            squirrel.Handle("Potato");
        }
    }
}
