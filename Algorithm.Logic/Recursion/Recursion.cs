using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.Recursion
{
    /// <summary>
    /// Simple recursion algorithm
    /// </summary>
    public class Recursion
    {
        /// <summary>
        /// Calculates a factorial using recursions
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated factorial</returns>
        public int CalculateFactorialWithRecursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * CalculateFactorialWithRecursion(number - 1);
        }

        /// <summary>
        /// Calculate factorial with loops
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int CalculateFactorialWithLoops(int number)
        {
            int result = number;

            while (number > 1)
            {
                number--;
                result = result * number;
            }

            return result;
        }
    }
}
