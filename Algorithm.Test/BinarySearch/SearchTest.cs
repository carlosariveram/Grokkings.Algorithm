﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm.Logic.BinarySearch;
using System.Diagnostics;

namespace Algorithm.Test.BinarySearch
{
    /// <summary>
    /// Test the search class
    /// </summary>
    [TestClass]
    public class SearchTest
    {
        /// <summary>
        /// Executes the search algorithm
        /// </summary>
        private readonly Search _searchAlgorithm;

        public SearchTest()
        {
           

            _searchAlgorithm = new Search();

        }

        /// <summary>
        /// Searches for the number in a shor collection of objects
        /// </summary>
        [TestMethod]
        public void VerifyTimeInSearch_Search_BinaryVsRegula()
        {
            int[] _testArray = new int[500];

            for (int i = 0; i < 500; i++)
                _testArray[i] = i;

            int number = new Random().Next(600);
            int count = 0;

            Stopwatch watch = new Stopwatch();

            watch.Start();
            var position = _searchAlgorithm.BinarySearch(_testArray, number, () => count++);
            watch.Stop();

            System.Diagnostics.Debug.Print($"Number of runs: {count}");

            if (position != null)
                Assert.AreEqual(number, _testArray[position.Value]);
            else
                Assert.IsTrue(number > 500);

            System.Diagnostics.Debug.Print(watch.ElapsedTicks.ToString());

            watch.Reset();

            count = 0;

            watch.Start();
            position = _searchAlgorithm.RegularSearch(_testArray, number, () => count++);
            watch.Stop();

            System.Diagnostics.Debug.Print($"Number of runs: {count}");

            System.Diagnostics.Debug.Print(watch.ElapsedTicks.ToString());

            if (position != null)
                Assert.AreEqual(number, _testArray[position.Value]);
            else
                Assert.IsTrue(number > 500);

        }

        /// <summary>
        /// Searches for the number in a large collection of objects
        /// </summary>
        [TestMethod]
        public void VerifyTimeInSearchIncreasedElements_Search_BinaryVsRegula()
        {
            int[] _testArray = new int[50000000];

            for (int i = 0; i < 50000000; i++)
                _testArray[i] = i;

            int number = new Random().Next(50000000);
            int count = 0;

            Stopwatch watch = new Stopwatch();

            watch.Start();
            var position = _searchAlgorithm.BinarySearch(_testArray, number, () => count++);
            watch.Stop();

            System.Diagnostics.Debug.Print($"Number of runs: {count}");

            if (position != null)
                Assert.AreEqual(number, _testArray[position.Value]);
            else
                Assert.IsTrue(number > 500);

            System.Diagnostics.Debug.Print(watch.ElapsedTicks.ToString());

            watch.Reset();

            count = 0;

            watch.Start();
            position = _searchAlgorithm.RegularSearch(_testArray, number, () => count++);
            watch.Stop();

            System.Diagnostics.Debug.Print($"Number of runs: {count}");

            System.Diagnostics.Debug.Print(watch.ElapsedTicks.ToString());

            if (position != null)
                Assert.AreEqual(number, _testArray[position.Value]);
            else
                Assert.IsTrue(number > 500);

        }

    }
}
