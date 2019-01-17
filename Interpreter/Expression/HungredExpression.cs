using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    class HungredExpression : Expression
    {
        protected override string Nine() => "CM";
        protected override string Five() => "D";
        protected override string Four() => "CD";
        protected override string One() => "C";
        protected override int Multiplier() => 100;
    }
}
