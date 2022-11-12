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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (hra.HraBezi == true)
            {
                Console.Clear();
                hra.Vypis();
                Console.WriteLine("Zadejte pohyb (nahoru, dolu, doprava, doleva): ");
                string smer = Console.ReadLine();
                try
                {
                    hra.PohniKarkulkou(smer);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Něco se pokazilo: " + e.Message);
                    Console.ReadKey();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Konec hry.");



        }

    }
}
