using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    class TenExpression : Expression
    {
        protected override string Nine() => "XC";
        protected override string Five() => "L";
        protected override string Four() => "XL";
        protected override string One() => "X";
        protected override int Multiplier() => 10;
    }
}
