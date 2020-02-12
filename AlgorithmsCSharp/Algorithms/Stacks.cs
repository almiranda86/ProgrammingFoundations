using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public class Stacks
    {
        private dynamic[] _Stacks = default;

        public int Count()
        {
            return _Stacks.Length;
        }

        public void Push(dynamic item)
        {
            if (_Stacks == null)
            {
                PushFirstItem(item);
            }
            else if (_Stacks.Length > 0)
            {
                PushRearangeStack(item);
            }
        }

        public dynamic Pop()
        {
            int pos = _Stacks.Length;
            var item = _Stacks[pos - 1];

            PopRearangeStack();

            return item;
        }

        private void PushFirstItem(dynamic item)
        {
            _Stacks = new dynamic[1];
            InsertStackItem(_Stacks, item);
        }

        private void PushRearangeStack(dynamic item)
        {
            dynamic tempStack = _Stacks;
            int posInit = _Stacks.Length;
            _Stacks = new dynamic[posInit + 1];
            
            InsertStackItem(_Stacks, item);

            for (int i = 0; i < tempStack.Length; i++)
            {
                _Stacks[i] = tempStack[i];
            }
        }

        private void InsertStackItem(dynamic Stack, dynamic item)
        {
            int pos = Stack.Length;
            Stack[pos - 1] = item;
        }

        private void PopRearangeStack()
        {
            dynamic tempStack = _Stacks;
            int posInit = _Stacks.Length;
            _Stacks = new dynamic[posInit - 1];

            for (int i = 0; i < tempStack.Length - 1; i++)
            {
                _Stacks[i] = tempStack[i];
            }
        }
    }
}
