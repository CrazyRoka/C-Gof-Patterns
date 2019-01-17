using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    class OneExpression : Expression
    {
        protected override string Nine() => "IX";
        protected override string Five() => "V";
        protected override string Four() => "IV";
        protected override string One() => "I";
        protected override int Multiplier() => 1;
    }
}
