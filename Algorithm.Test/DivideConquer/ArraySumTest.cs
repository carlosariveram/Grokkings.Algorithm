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
    /// Makes and addition of a Sum
    /// </summary>
    [TestClass]
    public class ArraySumTest
    {
        /// <summary>
        /// Algorithm
        /// </summary>
        private readonly ArraySum _algorithm;


        /// <summary>
        /// Constructor
        /// </summary>
        public ArraySumTest()
        {
            _algorithm = new ArraySum();
        }


        /// <summary>
        /// Sums all the elements of an array
        /// </summary>
        [TestMethod]
        public void SumsAllTheElementsOfTheArray_ArraySum_ReturnsTheTotalOfTheElements()
        {
            int result = _algorithm.Sum(new[] { 1, 2, 4, 5 });

            Assert.IsTrue(result == 12);
        }
    }
}
