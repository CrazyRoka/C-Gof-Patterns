using System;

namespace Visitor
{
    class VacationVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            switch (element)
            {
                case Director d:
                    Console.WriteLine($"Rest more, {d.Name}!");
                    d.NumberOfVacations += 2;
                    break;
                case Programmer p:
                    Console.WriteLine($"Programmer {p.Name} must rest in Gavai!");
                    p.NumberOfVacations += 7;
                    break;
                case Manager m:
                    Console.WriteLine($"Manager {m.Name} should work harder nowadays!");
                    m.NumberOfVacations -= 2;
                    break;
                default:
                    Console.WriteLine($"I can not visit {element}");
                    break;
            }
        }
    }
}