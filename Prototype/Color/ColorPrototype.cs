using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    abstract class ColorPrototype : ICloneable
    {
        public abstract object Clone();
    }
}
