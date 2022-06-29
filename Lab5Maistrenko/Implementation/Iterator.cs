using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Implementation
{
    public class Iterator<T> : IIterator<T>
    {
        private int current_;

        private List<T> list_;

        public Iterator(List<T> list)
        {
            list_ = list;
            Reset();
        }

        public T Current => list_.ElementAt(current_);

        public IIterator<T> Next()
        {
            return new Iterator<T>(list_, current_ + 1);
        }

        public void Reset()
        {
            current_ = 0;
        }

        public bool Finished()
        {
            return current_ >= list_.Count;
        }

        private Iterator(List<T> list, int index)
        {
            list_ = list;
            Reset();
            current_ = index;
        }
    }
}
