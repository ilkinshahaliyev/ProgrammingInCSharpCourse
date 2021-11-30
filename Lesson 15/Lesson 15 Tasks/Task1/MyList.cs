using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Task1
{
    public class MyList<T> : IEnumerable<T>
    {
        private readonly List<T> _items;

        public int Count
        {
            get
            {
                Contract.Ensures(Contract.Result<int>() >= 0);
                return _items.Count;
            }
            set
            {
            }
        }

        public MyList()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T GetElementByIndex(int index)
        {
            return _items[index];
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
