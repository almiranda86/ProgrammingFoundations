using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public interface ICommonDataStructures<T>
    {
        void Push(T item);

        T Pop();

        int Count();
    }
}
