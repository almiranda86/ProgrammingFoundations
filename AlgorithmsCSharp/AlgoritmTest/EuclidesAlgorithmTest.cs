using AlgorithmsCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoritmTest
{
    [TestClass]
    public class EuclidesAlgorithmTest
    {
        [TestMethod]
        public void GreatestCommonDenominatorTest()
        {
            //# try out the function with a few examples
            //GreatestCommonDenominatorTest(60, 96)) should be 12
            //GreatestCommonDenominatorTest(20, 8)) should be 4

            int x = EuclidesAlgorithm.GreatestCommonDenominator(60, 96);
            Assert.AreEqual(12, x);


            int y = EuclidesAlgorithm.GreatestCommonDenominator(20, 8);
            Assert.AreEqual(4, y);
        }
    }
}
