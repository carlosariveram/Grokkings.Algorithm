using Algorithm.Logic.DivideConquer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Test.DivideConquer
{
    /// <summary>
    /// Sort an array using quicksort algorithm
    /// </summary>
    [TestClass]
    public class QuicksortTest
    {
        /// <summary>
        /// Algorithm
        /// </summary>
        private readonly Quicksort algorithm;


        /// <summary>
        /// Constructor
        /// </summary>
        public QuicksortTest()
        {
            algorithm = new Quicksort();
        }


        /// <summary>
        /// Sorts an array
        /// </summary>
        [TestMethod]
        public void SortAnArray_QuickSort_SortedArray()
        {
            var testArray = new[] { 5, 4, 10, 4, 3, 1 };
            var result = algorithm.Sort(testArray);

            for (int i = 0; i < testArray.Length; i++)
            {
                Assert.IsTrue(new[] { 1, 3, 4, 4, 5, 10 }[i] == result[i]);
            }

            testArray = new[] { 15, 24, 1, 44, 3, 1, 9, 7, 3 };
            result = algorithm.Sort(testArray);

            for (int i = 0; i < testArray.Length; i++)
            {
                Assert.IsTrue(new[] { 1, 1, 3, 3, 7, 9, 15, 24, 44 }[i] == result[i]);
            }
        }
    }
}
