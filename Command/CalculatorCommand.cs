using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    enum Operation
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
    class CalculatorCommand : Command
    {
        private Operation _operation;
        private int _operand;
        private Calculator _calculator;
        public CalculatorCommand(Calculator calculator, Operation operation, int operand)
        {
            _calculator = calculator;
            _operation = operation;
            _operand = operand;
        }

        public void Execute()
        {
            _calculator.PerformOperation(_operation, _operand);
        }

        public void UnExecute()
        {
            _calculator.PerformOperation(Undo(_operation), _operand);
        }

        private Operation Undo(Operation operation)
        {
            switch (operation)
            {
                case Operation.Add: return Operation.Substract;
                case Operation.Substract: return Operation.Add;
                case Operation.Multiply: return Operation.Divide;
                case Operation.Divide: return Operation.Multiply;
                default: throw new ArgumentException();
            }
        }
    }
}
