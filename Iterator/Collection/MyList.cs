using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class MyList<T> : ICollection<T>
    {
        List<T> list = new List<T>();

        public void Add(T item) => list.Add(item);

        public int Count => list.Count;

        public Iterator<T> GetIterator() => new MyListIterator<T>(this);

        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
}
