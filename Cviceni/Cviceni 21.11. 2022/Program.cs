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
                    if(i != 1) yield return i;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Výpis raselinových jezer za použití cyklu foreach");
            foreach (string jezero in RaselinoveJezera())
            {
                Console.WriteLine(jezero);
            }
            Console.WriteLine();
            Console.WriteLine("Výpis jezer pomocí enumerátoru (iterátoru) ");
            IEnumerator enumerator = RaselinoveJezera().GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.WriteLine();
            Console.WriteLine("Výpis prvočísel");
            foreach (int cislo in PrvoCisla(1, 100))
            {
                Console.WriteLine(cislo);
            }
        }
    }
}
