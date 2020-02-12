using AlgorithmsCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmTest
{
    [TestClass]
    public class QueuesTest
    {
        private Queues InsertItems()
        {
            Queues queue = new Queues();
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);
            queue.Push(6);
            queue.Push(7);
            queue.Push(8);
            queue.Push(9);
            return queue;
        }

        [TestMethod]
        public void PushToQueueTest()
        {
            Queues stack = InsertItems();
            int total = stack.Count();
            Assert.AreEqual(9, total);
        }


        [TestMethod]
        public void PopFromQueueTest()
        {
            Queues queue = InsertItems();
            int total = queue.Count();
            Assert.AreEqual(9, total);
            var item = queue.Pop();
            Assert.AreEqual(1, item);

        }
    }
}
