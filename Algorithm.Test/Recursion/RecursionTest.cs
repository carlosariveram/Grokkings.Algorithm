using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecursionLogic = Algorithm.Logic.Recursion;

namespace Algorithm.Test.Recursion
{
    /// <summary>
    /// Test both of the recursion scenario
    /// </summary>
    [TestClass]
    public class RecursionTest
    {
        /// <summary>
        /// Algorithm
        /// </summary>
        private readonly RecursionLogic.Recursion _recursion;


        /// <summary>
        /// Constructor
        /// </summary>
        public RecursionTest()
        {
            _recursion = new Logic.Recursion.Recursion();
        }


        /// <summary>
        /// Recursion test
        /// </summary>
        [TestMethod]
        public void TestRecursions_Recursion_LoopHasBetterPerformance()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result1 = _recursion.CalculateFactorialWithRecursion(10);
            watch.Stop();

            var recursionTime = watch.ElapsedTicks;

            System.Diagnostics.Debug.Print($"Elapsed Recursion: {recursionTime.ToString()}");

            watch.Reset();

            watch.Start();
            var result = _recursion.CalculateFactorialWithLoops(10);
            watch.Stop();

            var loopTime = watch.ElapsedTicks;
            System.Diagnostics.Debug.Print($"Elapsed Loop: {loopTime.ToString()}");

            Assert.AreEqual(result, result1);
            Assert.IsTrue(recursionTime > loopTime);
        }
    }
}
