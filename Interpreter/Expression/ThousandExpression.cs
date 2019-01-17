using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    class ThousandExpression : Expression
    {
        protected override string Nine() => " ";
        protected override string Five() => " ";
        protected override string Four() => " ";
        protected override string One() => "M";
        protected override int Multiplier() => 1000;
    }
}
