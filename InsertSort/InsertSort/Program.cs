using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            pr1();
            Console.ReadKey();
        }
        public static void insertionSort(int[] list) {
            int item, j;
            for (int i = 1; i <= (list.Length - 1); i++) {
                item = list[i];
                j = i - 1;
                while ((j >= 0) && (list[j] > item)) {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = item;
            }
        }
        public static void pr1(){
            int n = 100000;
            Stopwatch sw = new Stopwatch();
            Random rng = new Random();
            int[] pole = new int[n];
            for(int i = 0; i < n; i++)
                pole[i]=rng.Next(-999,1000);
            sw.Start();
            insertionSort(pole);
            sw.Stop();
            long cas = sw.ElapsedMilliseconds;
            foreach(int c in pole)
                Console.WriteLine(c);
            Console.WriteLine("Čas: {0} ms",cas);
        }
    }
}
