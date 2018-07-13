using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.DivideConquer
{
    /// <summary>
    /// Maximum number class
    /// </summary>
    public class MaximumNumber
    {
        /// <summary>
        /// Finds the maximum number in an array
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="seed"></param>
        /// <returns>The maximum number</returns>
        public int Find(int[] numbers, int seed = 0)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            if (numbers.Length == 1)
                return seed;

            int numberSelected = numbers[numbers.Length - 1];
            int[] remainderArray = new int[numbers.Length - 1];

            Array.Copy(numbers, remainderArray, numbers.Length - 1);

            if (numberSelected > seed)
                seed = numberSelected;

            return Find(remainderArray, seed);

        }
    }
}
