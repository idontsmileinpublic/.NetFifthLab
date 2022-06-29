using Lab5.Interfaces;
using System.Collections.Generic;

namespace Lab5.Implementation
{
    public class CustomList<T> : IIterable<T>
    {
        private List<T> list_;

        public CustomList(List<T> list)
        {
            list_ = list;
        }

        public void Add(T item)
        {
            list_.Add(item);
        }

        public bool Remove(T item)
        {
            return list_.Remove(item);
        }

        public IIterator<T> GetIterator()
        {
            return new Iterator<T>(list_);
        }

        public IIterator<T> GetReverseIterator()
        {
            var copy = new List<T>(list_);
            copy.Reverse();
            return new Iterator<T>(copy);
        }
    }
}