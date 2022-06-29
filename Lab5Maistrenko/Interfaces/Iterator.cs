using System;

namespace Lab5.Interfaces
{
    public interface IIterator<T>
    {
        T Current { get; }
        void Reset();
        IIterator<T> Next();
        bool Finished();
    }
}
