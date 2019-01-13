using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    interface IXMLComponent
    {
        string ShowTree();
        void Add(IXMLComponent component);
        void Remove(IXMLComponent component);
    }
}
