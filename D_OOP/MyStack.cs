using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class MyStack<T>
    {
        private T[] _items;

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }

        public MyStack()
        {
            const int defaultCapasity = 4;
            _items = new T[defaultCapasity];
        }

        public MyStack(int capacity)
        {
            _items = new T[capacity];
        }

        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largeArray = new T[Count * 2];
                Array.Copy(_items, largeArray, Count);

                _items = largeArray;
            }
            _items[Count++] = item;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            _items[--Count] = default;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[Count - 1];
        }

    }
}
