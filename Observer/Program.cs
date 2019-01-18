using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company("Toch Industries");

            var investorRoka = new Investor("Roka");
            var investorJohn = new Investor("John");
            var investorRuslan = new Investor("Ruslan");
            var investorBodya = new Investor("Bodya");

            company.Attach(investorRoka);
            company.Attach(investorRuslan);
            company.Attach(investorBodya);
            company.Cash = 33.45;
            Console.WriteLine();

            company.Detach(investorRoka);
            company.Attach(investorJohn);
            company.Cash = 20.5;
            Console.WriteLine();
            company.Cash = 33;

        }
    }
}
