using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new XMLComposite("body");
            var div = new XMLComposite("div");
            var button = new XMLLeaf("button", "Click me");
            var input = new XMLLeaf("input");
            root.Add(div);
            div.Add(button);
            div.Add(input);

            Console.WriteLine(root.ShowTree());
        }
    }
}
