using AlgorithmsCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmTest
{
    [TestClass]
    public class StacksTest
    {
        private Stacks<int> InsertItems()
        {
            Stacks<int> stacks = new Stacks<int>();
            stacks.Push(1);
            stacks.Push(2);
            stacks.Push(3);
            stacks.Push(4);
            stacks.Push(5);
            stacks.Push(6);
            stacks.Push(7);
            stacks.Push(8);
            stacks.Push(9);
            return stacks;
        }

        [TestMethod]
        public void PushToStackTest()
        {
            Stacks<int> stack = InsertItems();
            int total = stack.Count();
            Assert.AreEqual(9, total);
        }


        [TestMethod]
        public void PopFromStackTest()
        {
            Stacks<int> stack = InsertItems();
            int total = stack.Count();
            Assert.AreEqual(9, total);
            var item = stack.Pop();
            Assert.AreEqual(9, item);

        }
    }
}
