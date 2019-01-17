using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    class Roman
    {
        public string Input { get; set; }
        public int Output { get; set; }

        public Roman(string input)
        {
            Input = input;
        }
    }
}
