using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Company
    {
        private List<Employee> _employees = new List<Employee>();

        public void Hire(Employee employee) => _employees.Add(employee);

        public void Dismiss(Employee employee) => _employees.Remove(employee);

        public void Accept(IVisitor visitor)
        {
            foreach (Employee employee in _employees)
            {
                employee.Accept(visitor);
            }
        }
    }
}
