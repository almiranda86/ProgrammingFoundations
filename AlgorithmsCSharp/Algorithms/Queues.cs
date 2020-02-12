using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public class Queues
    {
        private dynamic[] _Queues = default;

        public int Count()
        {
            return _Queues.Length;
        }

        public void Push(dynamic item)
        {
            if (_Queues == null)
            {
                PushFirstItem(item);
            }
            else if (_Queues.Length > 0)
            {
                PushRearangeQueue(item);
            }
        }

        public dynamic Pop()
        {
            var item = _Queues[0];

            PopRearangeQueue();

            return item;
        }

        private void PushFirstItem(dynamic item)
        {
            _Queues = new dynamic[1];
            InsertQueueItem(_Queues, item);
        }

        private void PushRearangeQueue(dynamic item)
        {
            dynamic tempQueues = _Queues;
            int posInit = _Queues.Length;
            _Queues = new dynamic[posInit + 1];

            InsertQueueItem(_Queues, item);

            for (int i = 0; i < tempQueues.Length; i++)
            {
                _Queues[i] = tempQueues[i];
            }
        }

        private void InsertQueueItem(dynamic Queue, dynamic item)
        {
            int pos = Queue.Length;
            Queue[pos - 1] = item;
        }

        private void PopRearangeQueue()
        {
            dynamic tempQueue = _Queues;
            int posInit = _Queues.Length;
            _Queues = new dynamic[posInit - 1];

            for (int i = 0; i < tempQueue.Length - 1; i++)
            {
                _Queues[i] = tempQueue[i + 1];
            }
        }
    }
}
