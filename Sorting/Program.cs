using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static void pr3(){
            int n = 100000;
            Stopwatch sw = new Stopwatch();
            Random rng = new Random();
            int[] pole1 = new int[n];
            int[] pole2 = new int[n];
            for(int i = 0; i < n; i++){
                pole1[i]=rng.Next(-1000,1000);
                pole2[i]=rng.Next(-1000,1000);
            }
            sw.Start();
            selectionSortS(pole1);
            sw.Stop();
            long cas1 = sw.ElapsedMilliseconds;
            sw.Start();
            Array.Sort(pole2);
            sw.Stop();
            long cas2 = sw.ElapsedMilliseconds;
            Console.WriteLine("Čas: {0} ms",cas1);
            Console.WriteLine("Čas: {0} ms",cas2-cas1);
        }
    }
}
