using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {
        public static void Sorting(int[] array, int first, int last)
        {
            int element = array[(last - first) / 2 + first];
            int i = first;
            int j = last;

            while (i <= j)
            {
                while (array[i] < element && i <= last)
                    ++i;

                while (array[j] > element && j >= first) 
                    --j;

                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i;
                    --j;
                }
            }

            if (j > first) 
                Sorting(array, first, j);

            if (i < last)
                Sorting(array, i, last);
        }
    }
}
