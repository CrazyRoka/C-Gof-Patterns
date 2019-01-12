using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get => _colors[key].Clone() as ColorPrototype;
            set => _colors.Add(key, value);
        }
    }
}
