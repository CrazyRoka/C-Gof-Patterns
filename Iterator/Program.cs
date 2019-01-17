using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(5);
            list.Add(3);
            list.Add(7);
            list.Add(8);
            list.Add(2);

            Iterator<int> iterator = list.GetIterator();
            while(!iterator.isDone)
            {
                Console.WriteLine(iterator.Next());
            }
            Console.WriteLine(iterator.First());
        }
    }
}
