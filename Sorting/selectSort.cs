using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class selectSort
    {
        public static void selectionSort(int[] list) {
            int temp, min;
            for (int i = 0; i < (list.Length - 1); i++) {
                min = list.Length - 1;
                // hledání minima
                for (int j = i; j < (list.Length - 1); j++)
                    if (list[min] > list[j])
                    min = j;
                // prohození prvku
                temp = list[min];
                list[min] = list[i];
                list[i] = temp;
            }
        }
    }
}
