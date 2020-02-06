using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public static class EuclidesAlgorithm
    {
        /// <summary>
        /// # Find the greatest common denominator of two numbers
        /// # using Euclid's algorithm
        /// For two integers A and B, where A > B, divide A by B
        /// If the reminder, R is Zero, then stop: The result is B
        /// Else, set A to B and B to R, and repeat until R is equals Zero
        /// </summary>
        public static int GreatestCommonDenominator(int a, int b)
        {
            while(b != 0)
            {
                //set the A value to a temp variable
                int t = a;
                //set A as B ahead of time
                a = b;
                //divide T(which is A) by B to achieve the NEW B
                b = t % b;
            }

            return a;
        }
    }
}
