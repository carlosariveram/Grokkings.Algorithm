using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.BinarySearch
{
    /// <summary>
    /// Searches a number in a collection
    /// </summary>
    public class Search
    {
        /// <summary>
        /// Uses binary search algorithm
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="numberToFind"></param>
        /// <returns>Nullable<int></returns>
        public int? BinarySearch(int[] numbers, int numberToFind, Action postCountCallback = null)
        {
            int minElement = 0;
            int maxElement = numbers.Length - 1;

            while(minElement <= maxElement)
            {
                int middle = Convert.ToInt32(Math.Ceiling((Convert.ToDecimal(minElement + maxElement)) / 2));

                if (numbers[middle] == numberToFind)
                    return middle;
                else if (numbers[middle] > numberToFind)
                    maxElement = middle - 1;
                else if (numbers[middle] < numberToFind)
                    minElement = middle + 1;

                if (postCountCallback != null)
                    postCountCallback();
            }

            return null;
        }

        /// <summary>
        /// Uses regular seach algorithm
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="numberToFind"></param>
        /// <returns>Nullable<int></returns>
        public int? RegularSearch(int[] numbers, int numberToFind, Action postCountCallback = null)
        {
            int minElement = 0;

            while(minElement < numbers.Length - 1)
            {
                if (numbers[minElement] == numberToFind)
                    return minElement;
                minElement++;

                if (postCountCallback != null)
                    postCountCallback();
            }

            return null;
        }
    }
}
