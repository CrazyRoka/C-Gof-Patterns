using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Compute(Operation.Add, 30);
            user.Compute(Operation.Substract, 20);
            user.Compute(Operation.Divide, 5);
            user.Compute(Operation.Multiply, -5);

            user.Undo(3);
            user.Redo(2);
            user.Compute(Operation.Multiply, 3);
        }
    }
}
