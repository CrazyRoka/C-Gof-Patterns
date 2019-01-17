using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class MyListIterator<T> : Iterator<T>
    {
        private MyList<T> _list;
        private int _cursor;
        public MyListIterator(MyList<T> list) => _list = list;

        public bool isDone => _cursor >= _list.Count;

        public T Current => _list[_cursor];

        public T First()
        {
            _cursor = 0;
            return Current;
        }

        public T Next()
        {
            T current = Current;
            _cursor++;
            return current;
        }
    }
}
