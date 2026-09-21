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
            Console.ReadKey();
        }

    }
}
