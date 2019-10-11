using System;
using QuickSort;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++) array[i] = random.Next(1, 50);

            Console.WriteLine("Array before sorting: \n");

            foreach (var arr in array) Console.Write($"{arr} ");

            QuickSort.Sorting(array, 0, array.Length - 1);

            Console.WriteLine("\n\nArray after sorting: \n");

            foreach (var arr in array) Console.Write($"{arr} ");

            Console.ReadKey();
        }
    }
}
