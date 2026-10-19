using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            pr3();
            Console.ReadKey();
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

        /*
            vytvořte program, který do pole náhodně vygeneruje 1000 čísel v intervalu -1000 až 1000
            program se zeptá, zda chceme čísla vypsat seřazená vzestupně nebo sestupně
            následně seřazené hodnoty vypíše
            použijde vytvořené metody pro řazení
        */
        public static void pr1()
        {
            Random rnd = new Random();
            int[] pole = new int[1000];
            for (int i = 0; i < pole.Length; i++)
                pole[i] = rnd.Next(-1000, 1001);

            Console.Write("Vypsat cisla vzestupne (v) nebo sestupne (s)? ");
            string volba = Console.ReadLine().Trim().ToLower();

            if (volba == "s")
                selectionSortS(pole);
            else
                selectionSortVz(pole);

            foreach (int x in pole) Console.Write(x + "; ");
            Console.WriteLine();

        }
        public static void pr2(){
            int n = 1000000;
            Stopwatch sw = new Stopwatch();
            Random rng = new Random();
            int[] pole = new int[n];
            for(int i = 0; i < n; i++)
                pole[i]=rng.Next(-1000,1000);
            sw.Start();
            selectionSortS(pole);
            sw.Stop();
            long cas = sw.ElapsedMilliseconds;
            foreach(int c in pole)
                Console.WriteLine(c);
            Console.WriteLine("Čas: {0} ms",cas);
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
