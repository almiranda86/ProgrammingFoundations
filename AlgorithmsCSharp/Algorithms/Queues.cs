using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public class Queues<T> : ICommonDataStructures<T>
    {
        private T[] items;
        private int total;
        private const int initValue = 8;
        private int queueHead = 0;

        public Queues()
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
            T item = items[queueHead];
            items[queueHead] = default(T);
            queueHead = (queueHead + 1) % items.Length;
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
