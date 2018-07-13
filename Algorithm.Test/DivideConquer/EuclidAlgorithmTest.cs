using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm.Logic.DivideConquer;

namespace Algorithm.Test.DivideConquer
{
    /// <summary>
    /// Summary description for EuclidAlgorithmTest
    /// </summary>
    [TestClass]
    public class EuclidAlgorithmTest
    {
        /// <summary>
        /// Algorithm
        /// </summary>
        private readonly EuclidAlgorithm _algorithm;


        /// <summary>
        /// Constructor
        /// </summary>
        public EuclidAlgorithmTest()
        {
            _algorithm = new EuclidAlgorithm();
        }

        /// <summary>
        /// Test Euclid's algorithm's
        /// </summary>
        [TestMethod]
        public void FindsTheGreatestCommonDivisorUsingDivideAndConquer_FindGreatestCommonDivisor_ReturnGreatesCommonDivisor()
        {
            int result = _algorithm.FindGreatestCommonDivisor(1000, 375);

            Assert.IsTrue(result == 125);
        }
    }
}
