using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class MyStack<T> : IEnumerable<T>
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

        //public IEnumerator<T> GetEnumerator()
        //{
        //    return new StackEnumerator<T>(_items, Count);
        //}

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i >= 0; i--)
            {
                yield return _items[i];
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private readonly int count;
        private int position = -1;

        public StackEnumerator(T[] array, int count)
        {
            this.array = array;
            this.count = count;

            position = count;
        }

        private IEnumerator<T> enumeratorImplementation;
        public bool MoveNext()
        {
            position--;
            return position >= 0;
        }

        public void Reset()
        {
            position = count;
        }

        public T Current
        {
            get
            {
                return array[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;

            }
        }

        public void Dispose()
        {
        }
    }

}
