using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickSort.Test
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void Sort_RandomNumbers_SortedReturn()
        {
            var actual = new int[10];

            Random random = new Random();

            for (int i = 0; i < actual.Length; i++)
                actual[i] = random.Next(1, 50);

            var expected = new List<int>(actual);
            expected.Sort();

            Dll.QuickSort.Sort(actual, 0, actual.Length - 1);

            CollectionAssert.AreEqual(expected.ToArray(), actual);
        }

        [TestMethod]
        public void Sort_RandomNumbers_PartedSortedReturn()
        {
            var actual = new int[10];

            Random random = new Random();

            for (int i = 0; i < actual.Length; i++)
                actual[i] = random.Next(1, 50);

            var expected = new List<int>(actual);
            expected.Sort(5, 2, Comparer<int>.Default);

            Dll.QuickSort.Sort(actual, 5, 6);

            CollectionAssert.AreEqual(expected.ToArray(), actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Sort_NullArray_ExceptionReturn()
        {
            Dll.QuickSort.Sort(null, 0 , 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_NegativeFirstIndex_ExceptionReturn()
        {
            var array = new int[10];

            Dll.QuickSort.Sort(array, -5, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_NegativeLastIndex_ExceptionReturn()
        {
            var array = new int[10];

            Dll.QuickSort.Sort(array, 0, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_LastIndexOutOfBound_ExceptionReturn()
        {
            var array = new int[0];

            Dll.QuickSort.Sort(array, 0, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_FirstIndexExceedsLastIndex_ExceptionReturn()
        {
            var array = new int[10];

            Dll.QuickSort.Sort(array, 7, 5);
        }
    }
}
