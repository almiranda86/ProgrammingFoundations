using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public class Stacks<T> : ICommonDataStructures<T>
    {
        private T[] items;
        private int total;
        private const int initValue = 8;

        public Stacks()
        {
            items = new T[initValue];
            total = 0;
        }

        public int Count()
        {
            return total;
        }

        public T Pop()
        {
            T item = items[--total];
            items[total] = default(T);
            return item;
        }

        public void Push(T item)
        {
            if (total == items.Length)
            {
                Array.Resize(ref items, (items.Length + 1) * 2);
            }

            items[total++] = item;
        }
    }
}
