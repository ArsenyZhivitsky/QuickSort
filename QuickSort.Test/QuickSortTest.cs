using System;
using System.Collections.Generic;
using System.Linq;
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

            var random = new Random();

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

        // Need to be able to sort using empty arrays
        [TestMethod]
        public void Sort_EmptyArray()
        {
            var actual = new int[0];
            Dll.QuickSort.Sort(actual);
        }

        // and one element arrays
        [TestMethod]
        public void Sort_OneElement()
        {
            var actual = new[] { 1 };
            Dll.QuickSort.Sort(actual);
        }

        // and large arrays
        [TestMethod]
        public void Sort_Large()
        {
            var rnd = new Random();
            var arr = Enumerable.Range(0, 5000).Select(x => rnd.Next(0, 10000)).ToArray();
            var copy = new List<int>(arr);
            Dll.QuickSort.Sort(arr);
            copy.Sort();
            CollectionAssert.AreEqual(copy.ToArray(), arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Sort_NullArray_ExceptionReturn()
        {
            Dll.QuickSort.Sort(null, 0, 5);
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
