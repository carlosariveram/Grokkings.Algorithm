using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Logic.SelectionSort
{
    /// <summary>
    /// Sorts an array
    /// </summary>
    public class Sort
    {
        /// <summary>
        /// Uses selection sort to sort an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Arry sorted</returns>
        public int[] SelectionSort(int[] array)
        {
            int[] resultArray = new int[array.Length];
            int i = 0;

            while(array.Length > 0)
            {
                int smallest = getSmallestIndex(array);
                resultArray[i] = array[smallest];
                i++;
                array = array.Where((elem, index) => index != smallest).ToArray(); // Theres no easy way to remove an element from an array, we can use a list instead 
            }

            return resultArray;

        }


        /// <summary>
        /// Retrieves the smallest index of an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Position of the smallest</returns>
        private int getSmallestIndex(int[] array)
        {
            int smallest = array[0];
            int smallestPosition = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                    smallestPosition = i;
                }
            }

            return smallestPosition;
        }
    }
}
