using AlgorithmsCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmTest
{
    [TestClass]
    public class RecursionTest
    {
        [TestMethod]
        public void CountDownTest()
        {
            Recursion recursion = new Recursion();

            string expected = "Done!";

            string result = recursion.countdown(5);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PowerTest()
        {
            Recursion recursion = new Recursion();

            int expected = 16;

            int result = recursion.power(2, 4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FactorialTest()
        {
            Recursion recursion = new Recursion();

            int expected = 120;

            int result = recursion.factorial(5);

            Assert.AreEqual(expected, result);
        }
    }
}
