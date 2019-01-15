using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Calculator
    {
        private int _curr = 0;

        public void PerformOperation(Operation operation, int operand)
        {
            int previous = _curr;
            switch (operation)
            {
                case Operation.Add: _curr += operand; break;
                case Operation.Substract: _curr -= operand; break;
                case Operation.Multiply: _curr *= operand; break;
                case Operation.Divide: _curr /= operand; break;
            }
            Console.WriteLine($"Current value = {previous}. " +
                $"Performing operation {operation.ToString()} with operand {operand}. " +
                $"Result = {_curr}");
        }
    }
}
