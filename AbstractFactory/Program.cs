using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UseUkraineItems();
            UseAmericaItems();
        }

        public static void UseUkraineItems()
        {
            AbstractFactory factory = new UkraineFactory();
            PrintNames(factory);
        }

        public static void UseAmericaItems()
        {
            AbstractFactory factory = new AmericanFactory();
            PrintNames(factory);
        }

        public static void PrintNames(AbstractFactory factory)
        {
            ICar car = factory.GetCar();
            ICompany company = factory.GetCompany();
            Console.WriteLine($"I have {car.Name} and work at {company.Name}");
        }
    }
}
