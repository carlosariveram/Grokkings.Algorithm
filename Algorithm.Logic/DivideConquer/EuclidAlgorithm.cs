using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.DivideConquer
{
    /// <summary>
    /// Euclid's algorithm finds the greatest common divisor between to numbers by using the following approach:
    /// GCD(A, B): Greatest common divisor of A and B
    /// A = Q*B + R, where Q is a quotient and R is the remainder
    /// Euclid's algorithm states that GCD(A, B) = GCD(B, R)
    /// And GCD(A, 0) = A and GCD(0, B) = B
    /// </summary>
    public class EuclidAlgorithm
    {
        /// <summary>
        /// Find the greatest common divisor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>The greatest common divisor</returns>
        public int FindGreatestCommonDivisor(int a, int b)
        {
            //Euclid's algorithm base case
            if (a == 0)
                return b;
            else if (b == 0)
                return a;           
            
            // Recursion case
            int quotient = a / b;
            int remainder = a % b;

            return FindGreatestCommonDivisor(b, remainder);
        }
    }
}
