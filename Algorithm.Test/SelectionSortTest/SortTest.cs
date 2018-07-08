using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm.Logic.SelectionSort;

namespace Algorithm.Test.SelectionSortTest
{
    /// <summary>
    /// Summary description for SortTest
    /// </summary>
    [TestClass]
    public class SortTest
    {
        /// <summary>
        /// Sort Algorithm
        /// </summary>
        private readonly Sort _sort;


        /// <summary>
        /// Constructor
        /// </summary>
        public SortTest()
        {
            _sort = new Sort();
        }



        /// <summary>
        /// Verify the sorted array
        /// </summary>
        [TestMethod]
        public void SortsAnArray_Sort_SortedArrayAscending()
        {
            int[] elements = new int[500];
            var random = new Random();

            for (int i = 0; i < 500; i++)
                elements[i] = random.Next();

            var sortedArray = _sort.SelectionSort(elements);

            Assert.IsTrue(!sortedArray.Equals(elements));
        }
    }
}
