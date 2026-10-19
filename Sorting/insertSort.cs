using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class insertSort
    {
        public static void insertionSort(int[] list)
        {
            int item, j;
            for (int i = 1; i <= (list.Length - 1); i++)
            {
                item = list[i];
                j = i - 1;
                while ((j >= 0) && (list[j] > item))
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = item;
            }
        }
    }
}
