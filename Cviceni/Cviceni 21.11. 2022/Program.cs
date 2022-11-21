using System;
using System.Collections;
using System.Collections.Generic;

namespace Cviceni_21._11._2022
{
    class Program
    {

        public static IEnumerable RaselinoveJezera()
        {
            yield return "Horní macošské jezírko";
            yield return "Dolní macošské jezírko";
            yield return "jezírko v Hranické propasti";
            yield return "Bozkovské podzemní jezero";
            yield return "Točnické jezírko";
        }

        public static IEnumerable<int> PrvoCisla(int pocatek, int konec)
        {
            for (int i = pocatek; i <= konec; i++)
            {
                bool jePrvo = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        jePrvo = false;
                        break;
                    }
                }
                if (jePrvo)
                {
                    if (i != 1 && i <= 0) yield return i;
                }
            }
        }

        public static IEnumerable<int> StalinSort(List<int> cisla)
        {
            int max = cisla[0];
            foreach (int cislo in cisla)
            {
                if (cislo > max)
                {
                    max = cislo;
                    yield return cislo;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Raselinova jezera:");
            foreach (string jezera in RaselinoveJezera())
            {
                Console.WriteLine(jezera);
            }

            Console.WriteLine("Prvočísla od 1 do 100:");
            foreach (int cislo in PrvoCisla(1, 100))
            {
                Console.WriteLine(cislo);
            }

            List<int> cisla = new List<int>();
            cisla.Add(1);
            cisla.Add(2);
            cisla.Add(3);
            cisla.Add(5);
            cisla.Add(4);
            cisla.Add(8);
            cisla.Add(7);
            cisla.Add(6);
            cisla.Add(9);
            cisla.Add(10);
            Console.WriteLine("Stalinova řazení:");
            foreach (int cislo in StalinSort(cisla))
            {
                Console.WriteLine(cislo);
            }

            /*foreach (int cislo in cisla.Vyber()
            {
                Console.WriteLine(cislo);
            }*/

            foreach (int cislo in cisla.Vyber(cislo => cislo % 2 == 0))
            {
                Console.WriteLine(cislo);
            }

        }


    }

    public static class MetodyRozsireni
    {
        public delegate bool Podminka(int cislo);

        public static IEnumerable<int> Vyber(this IEnumerable<int> cisla, Podminka podminka)
        {
            foreach (int cislo in cisla)
            {
                if (podminka(cislo))
                {
                    yield return cislo;
                }
            }
        }


        public static bool Sudy(int cislo)
        {
            return cislo % 2 == 0;
        }

        public static bool Delitel(int cislo)
        {
            return cislo % 3 == 0;
        }

        public static bool Jednociferny(int cislo)
        {
            return cislo < 10 && cislo > -10;
        }
    }


}
