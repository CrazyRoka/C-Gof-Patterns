using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    abstract class Expression
    {
        public void Interpret(Roman roman)
        {
            if (roman.Input.Length == 0)
                return;

            if(roman.Input.StartsWith(Nine()))
            {
                roman.Output += 9 * Multiplier();
                roman.Input = roman.Input.Substring(2);
            }

            if (roman.Input.StartsWith(Five()))
            {
                roman.Output += 5 * Multiplier();
                roman.Input = roman.Input.Substring(1);
            }

            if (roman.Input.StartsWith(Four()))
            {
                roman.Output += 4 * Multiplier();
                roman.Input = roman.Input.Substring(2);
            }

            while(roman.Input.StartsWith(One()))
            {
                roman.Output += Multiplier();
                roman.Input = roman.Input.Substring(1);
            }
        }

        protected abstract string One();
        protected abstract string Four();
        protected abstract string Five();
        protected abstract string Nine();
        protected abstract int Multiplier();
    }
}
