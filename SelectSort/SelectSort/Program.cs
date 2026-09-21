using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            pr1();
        }

        public static void selectionSortVz(int[] pole)
        {
            for (int j = 0; j < pole.Length - 1; j++)
            {
                int pozice = j;
                for (int i = j + 1; i < pole.Length; i++)
                    if (pole[i] < pole[pozice])
                        pozice = i;
                int tmp = pole[j];
                pole[j] = pole[pozice];
                pole[pozice] = tmp;
            }
        }
        public static void selectionSortS(int[] pole)
        {
            for (int j = 0; j < pole.Length - 1; j++)
            {
                int pozice = j;
                for (int i = j + 1; i < pole.Length; i++)
                    if (pole[i] > pole[pozice])
                        pozice = i;
                int tmp = pole[j];
                pole[j] = pole[pozice];
                pole[pozice] = tmp;
            }
        }
        public static void pr1()
        {
            int[] pole = {10,1,2,15,-1,8};
            selectionSortS(pole);
            foreach (int x in pole) Console.Write(x + "; ");
            Console.WriteLine();
            selectionSortVz(pole);
            foreach (int x in pole) Console.Write(x + "; ");
            Console.ReadKey();
        }


    }
}
