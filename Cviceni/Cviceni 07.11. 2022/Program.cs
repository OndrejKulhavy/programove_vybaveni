using System;
using Cviceni_07._11._2022.Enums;
using Cviceni_07._11._2022.Policka;

namespace Cviceni_07._11._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Hra hra = new Hra();
            hra.Vypis();
            Console.WriteLine();
            hra.Vypis();

            hra.PridatSpecialniPolicko(Typ.DOMECEK_BABICKY);
            Console.WriteLine();
            hra.Vypis();

            hra.PohniKarkulkou(Smer.VLEVO);
            Console.WriteLine();
            hra.Vypis();


            hra.PohniKarkulkou(Smer.NAHORU);
            Console.WriteLine();
            hra.Vypis();
            hra.PohniKarkulkou(Smer.VLEVO);
            Console.WriteLine();
            hra.Vypis();
            hra.PohniKarkulkou(Smer.VLEVO);
            Console.WriteLine();
            hra.Vypis();
            hra.PohniKarkulkou(Smer.VLEVO);
            Console.WriteLine();
            hra.Vypis();

        }

    }
}
