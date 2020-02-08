using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public class LinkedList
    {
        private Node Head;
        private int Count;

        public LinkedList(Node head = null)
        {
            Head = head;
            Count = 0;
        }

        public int get_count()
        {
            return Count;
        }

        public void insert(int val)
        {
            Node new_node = new Node(val);
            new_node.set_next(Head);
            Head = new_node;
            Count += 1;
        }

        public Node find(int val)
        {
            Node item = Head;
            while (item != null)
            {
                if (item.get_data() == val)
                {
                    return item;
                }
                else
                {
                    item = item.get_next();
                }
            }
            return null;
        }

        public void deleteAt(int idx)
        {
            if (idx > Count)
            {
                return;
            }


            if (Head == null)
            {
                return;
            }
            else
            {
                int tempIdx = 0;
                Node node = Head;
                while (tempIdx < idx - 1)
                {
                    node = node.get_next();
                    tempIdx += 1;
                }

                //node.set_next(node.get_next().get_next());
                var n1 = node.get_next();
                var n2 = n1.get_next();
                node.set_next(n2);

                Count -= 1;
            }
        }


        public void dump_list()
        {
            Node tempnode = Head;
            while (tempnode != null)
            {
                tempnode = tempnode.get_next();
            }
        }        
    }

    public class Node
    {
        public int Val;
        private dynamic Next;

        public Node(int val)
        {
            Val = val;
            Next = null;
        }

        public int get_data()
        {
            return Val;
        }

        public void set_data(int val)
        {
            Val = val;
        }

        public dynamic get_next()
        {
            return Next;
        }

        public void set_next(Node next)
        {
            Next = next;
        }
    }
}
