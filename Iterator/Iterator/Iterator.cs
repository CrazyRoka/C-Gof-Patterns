using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface Iterator<T>
    {
        T First();
        T Next();
        bool isDone { get; }
        T Current { get; }
    }
}
