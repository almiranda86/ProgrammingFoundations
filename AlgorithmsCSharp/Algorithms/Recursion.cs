using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public class Recursion
    {
        public string countdown(int i)
        {
            string result = "";

            if (i == 0)
            {
                result = "Done!";
            }
            else
            {
                result = countdown(i - 1);
            }

            return result;
        }

        public int factorial(int i)
        {
            int result = 0;

            if (i == 0)
            {
                return 1;
            }
            else
            {
                result = i * factorial(i - 1);
            }

            return result;
        }

        public int power(int i, int p)
        {
            int result = 0;

            if (p == 0)
            {
                return 1;
            }
            else
            {
                result = i * power(i, p - 1);
            }

            return result;
        }
    }
}
