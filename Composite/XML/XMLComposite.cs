using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class XMLComposite : IXMLComponent
    {
        private string _name;
        private List<IXMLComponent> components = new List<IXMLComponent>();
        public XMLComposite(string name) => _name = name;

        public void Add(IXMLComponent component) => components.Add(component);

        public void Remove(IXMLComponent component) => components.Remove(component);

        public string ShowTree()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"<{_name}>");
            foreach (IXMLComponent component in components)
            {
                builder.AppendLine(component.ShowTree());
            }
            builder.AppendLine($"</{_name}>");
            return builder.ToString();
        }
    }
}
