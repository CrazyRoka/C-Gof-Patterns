using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    interface Command
    {
        void Execute();
        void UnExecute();
    }
}
