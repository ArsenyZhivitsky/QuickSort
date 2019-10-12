using System;

namespace QuickSort.Dll
{
    public static class QuickSort
    {
        public static void Sort(int[] array, int firstIndex, int lastIndex)
        {
            ValidateArguments(array, firstIndex, lastIndex);

            PerformSort(array, firstIndex, lastIndex);
        }

        private static void ValidateArguments(int[] array, int firstIndex, int lastIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "\nArray is null");
            }

            if (firstIndex < 0)
            {
                throw new ArgumentException("\nFirst index is less than 0", nameof(firstIndex));
            }

            if (lastIndex < 0)
            {
                throw new ArgumentException("\nLast index is less than 0", nameof(lastIndex));
            }

            if (lastIndex >= array.Length)
            {
                throw new ArgumentException("\nLast index is greater or equal than array length");
            }

            if (firstIndex >= lastIndex)
            {
                throw new ArgumentException("\nFirst index is greater or equal than last index");
            }
        }

        private static void PerformSort(int[] array, int firstIndex, int lastIndex)
        {
            int element = array[(lastIndex - firstIndex) / 2 + firstIndex];
            int i = firstIndex;
            int j = lastIndex;

            while (i <= j)
            {
                while (array[i] < element && i <= lastIndex)
                    ++i;

                while (array[j] > element && j >= firstIndex)
                    --j;

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i;
                    --j;
                }
            }

            if (j > firstIndex)
                PerformSort(array, firstIndex, j);

            if (i < lastIndex)
                PerformSort(array, i, lastIndex);
        }
    }
}
