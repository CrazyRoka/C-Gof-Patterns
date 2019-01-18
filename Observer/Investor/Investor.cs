using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Investor : IInvestor
    {
        private string _name;
        public Investor(string name) => _name = name;

        public void Update(ICompany company)
        {
            Console.WriteLine($"Investor {_name} received update from {company}. Current cash: {company.Cash}");
        }
    }
}
