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
    public class ListItemCountTest
    {
        /// <summary>
        /// List Item Count
        /// </summary>
        private readonly ListItemCount _algorithm;


        /// <summary>
        /// Constructor
        /// </summary>
        public ListItemCountTest()
        {
            _algorithm = new ListItemCount();
        }

        /// <summary>
        /// Test Euclid's algorithm's
        /// </summary>
        [TestMethod]
        public void CountTheNumberOfItemList_Count_ReturnTheNumberOfItem()
        {
            int result = _algorithm.Count(new List<string>() { "Hello", "World", "!" });

            Assert.IsTrue(result == 3);
        }
    }
}
