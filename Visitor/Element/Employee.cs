using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Employee : IElement
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int NumberOfVacations { get; set; }

        public Employee(string name, double salary, int numberOfVacations)
        {
            Name = name;
            Salary = salary;
            NumberOfVacations = numberOfVacations;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
