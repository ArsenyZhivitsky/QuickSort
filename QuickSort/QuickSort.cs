using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {
        public static void Sorting(double[] array, long first, long last)
        {
            double element = array[(last - first) / 2 + first];
            long i = first;
            long j = last;

            while (i <= j)
            {
                while (array[i] < element && i <= last) ++i;

                while (array[j] > element && j >= first) --j;

                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i;
                    --j;
                }
            }

            if (j > first) Sorting(array, first, j);

            if (i < last) Sorting(array, i, last);
        }
    }
}
