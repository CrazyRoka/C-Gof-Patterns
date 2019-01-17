using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Roman roman = new Roman("MMMCCXXXIV");

            List<Expression> expressions = new List<Expression>();
            expressions.Add(new ThousandExpression());
            expressions.Add(new HungredExpression());
            expressions.Add(new TenExpression());
            expressions.Add(new OneExpression());

            foreach(Expression expression in expressions)
            {
                expression.Interpret(roman);
            }

            Console.WriteLine(roman.Output);
        }
    }
}
