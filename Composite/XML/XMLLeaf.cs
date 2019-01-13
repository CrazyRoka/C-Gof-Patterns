using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class XMLLeaf : IXMLComponent
    {
        private string _node;
        public XMLLeaf(string name, string value = "") => _node = $"<{name}>{value}</{name}>";

        public void Add(IXMLComponent component) => Console.WriteLine("Can't add to leaf");

        public void Remove(IXMLComponent component) => Console.WriteLine("Can't remove from leaf");

        public string ShowTree() => _node;
    }
}
