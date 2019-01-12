using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyGamingPC();
            BuyOfficePC();
        }

        public static void BuyGamingPC()
        {
            Seller seller = new Seller();
            seller.SetSeller(new GamingComputerBuilder());
            seller.ConstructComputer();
            Console.WriteLine(seller.GetComputer());
        }

        public static void BuyOfficePC()
        {
            Seller seller = new Seller();
            seller.SetSeller(new OfficeComputerBuilder());
            seller.ConstructComputer();
            Console.WriteLine(seller.GetComputer());
        }
    }
}
