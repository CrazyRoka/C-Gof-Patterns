using System;

namespace Visitor
{
    class IncomeVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            switch (element)
            {
                case Director d:
                    Console.WriteLine($"Ohh, salary is big enough in {d.Name}");
                    break;
                case Programmer p:
                    Console.WriteLine($"I will increase salary for {p.Name}");
                    p.Salary *= 1.1;
                    break;
                case Manager m:
                    Console.WriteLine($"I hate managers. Decrease salary for {m.Name}");
                    m.Salary *= 0.9;
                    break;
                default:
                    Console.WriteLine($"I can not visit {element}");
                    break;
            }
        }
    }
}