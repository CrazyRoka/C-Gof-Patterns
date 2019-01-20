using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Hire(new Director("Rostyslav Toch"));
            company.Hire(new Programmer("Ruslan Filuk"));
            company.Hire(new Programmer("Yurii Luchka"));
            company.Hire(new Programmer("Anastasia Tarasenko"));
            company.Hire(new Manager("Luda Berezovska"));

            company.Accept(new IncomeVisitor());
            company.Accept(new VacationVisitor());
        }
    }
}
