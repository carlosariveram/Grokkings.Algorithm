using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm.Logic.DivideConquer;

namespace Algorithm.Test.DivideConquer
{
    /// <summary>
    /// List Item Count 
    /// </summary>
    [TestClass]
    public class MaximumNumberTest
    {
        /// <summary>
        /// List Item Count
        /// </summary>
        private readonly MaximumNumber _algorithm;


        /// <summary>
        /// Constructor
        /// </summary>
        public MaximumNumberTest()
        {
            _algorithm = new MaximumNumber();
        }

        /// <summary>
        /// Test Euclid's algorithm's
        /// </summary>
        [TestMethod]
        public void GetTheMaximumNumberOfElements_Gets_ReturnTheMaximumNumber()
        {
            int result = _algorithm.Find(new int[] { 1, 1, 1, 5, 4, 2200, 3, 9});

            Assert.IsTrue(result == 2200);
        }
    }
}
