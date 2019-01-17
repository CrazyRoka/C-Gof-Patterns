using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface ICollection<T>
    {
        Iterator<T> GetIterator();
    }
}
