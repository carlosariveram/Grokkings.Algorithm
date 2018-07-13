using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.DivideConquer
{
    /// <summary>
    /// Sums and array
    /// </summary>
    public class ArraySum
    {
        /// <summary>
        /// Sums an array of numbers using divide and conquer strategy
        /// </summary>
        /// <param name="arrayNumbers"></param>
        /// <returns></returns>
        public int Sum(int[] arrayNumbers)
        {
            if (arrayNumbers.Length == 0) return 0;
            if (arrayNumbers.Length == 1) return arrayNumbers[0];

            int[] resultArray = new int[arrayNumbers.Length - 1];

            Array.Copy(arrayNumbers, resultArray, arrayNumbers.Length - 1);
            return arrayNumbers[arrayNumbers.Length - 1] + Sum(resultArray);
        }
    }
}
