using System;

namespace Lab5.Interfaces
{
    public interface IIterable<T>
    {
        IIterator<T> GetIterator();
        IIterator<T> GetReverseIterator();
    }
}
