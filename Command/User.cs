using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class User
    {
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();
        private int _current = 0;

        public void Redo(int level)
        {
            Console.WriteLine($"Redo {level} times");
            for(int i = 0; i < level && _current < _commands.Count; i++, _current++)
            {
                Command command = _commands[_current];
                command.Execute();
            }
        }

        public void Undo(int level)
        {
            Console.WriteLine($"Undo {level} times");
            for(int i = 0; i < level && _current > 0; i++)
            {
                Command command = _commands[--_current];
                command.UnExecute();
            }
        }

        public void Compute(Operation operation, int operand)
        {
            Command command = new CalculatorCommand(_calculator, operation, operand);
            command.Execute();

            if (_current < _commands.Count) _commands.RemoveRange(_current, _commands.Count - _current);
            _commands.Add(command);
            _current++;
        }
    }
}
