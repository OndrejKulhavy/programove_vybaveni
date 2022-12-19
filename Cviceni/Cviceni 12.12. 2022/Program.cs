using System;

namespace Cviceni_12._12._2022
{
    class Program
    {

        static void Main(string[] args)
        {
            //1. část
            Func<string, string> naVelkaPismena = (string s) => s.ToUpper();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Action<int> vypis = (int i) => Console.WriteLine(i);
            vypis(5);
            Predicate<int> delitelnePeti = (int i) => i % 5 == 0;
            Console.WriteLine(delitelnePeti(1));

            //2. část
            Zamestanec zamestanec1 = new Zamestanec("Petr", "Novák", 20000, Pozice.Programator, new DateTime(2021, 1, 1));
            Zamestanec zamestanec2 = new Zamestanec("Josef", "Kulhavý", 30000, Pozice.Tester, new DateTime(2021, 2, 1));
            Zamestanec zamestanec3 = new Zamestanec("Pavel", "Novotný", 40000, Pozice.Manager, new DateTime(2021, 3, 1));
            Zamestanec zamestanec4 = new Zamestanec("Petr", "Novák", 50000, Pozice.CEO, new DateTime(2021, 4, 1));
            Zamestanec zamestanec5 = new Zamestanec("Danuše", "Nerudová", 60000, Pozice.Programator, new DateTime(2021, 5, 1));
            Zamestanec zamestanec6 = new Zamestanec("Simona", "Césarová", 70000, Pozice.Tester, new DateTime(2021, 6, 1));
            Zamestanec zamestanec7 = new Zamestanec("Albína", "Nováková", 10000, Pozice.Programator, new DateTime(2021, 7, 1));
            Zamestanec zamestanec8 = new Zamestanec("Albína", "Nováková", 10000, Pozice.Programator, new DateTime(2021, 7, 1));

            Firma firma = new Firma("Firma");
            firma.PridejZamestnance(zamestanec1);
            firma.PridejZamestnance(zamestanec2);
            firma.PridejZamestnance(zamestanec3);
            firma.PridejZamestnance(zamestanec4);
            firma.PridejZamestnance(zamestanec5);
            firma.PridejZamestnance(zamestanec6);
            firma.PridejZamestnance(zamestanec7);
            firma.PridejZamestnance(zamestanec8);

            Console.WriteLine("\nNejvyšší plat: ");
            foreach (var zamestanec in firma.NejvyssiPlat())
            {
                Console.WriteLine(zamestanec);
            }

            Console.WriteLine("\nPrůměrný plat: ");
            Console.WriteLine(firma.PrumerPlatu());

            Console.WriteLine("\nPrůměrný plat programátorů: ");
            Console.WriteLine(firma.PrumerPlatu(Pozice.Programator));


            Console.WriteLine("\nTop 3 nejvyšší plat: ");
            foreach (var zamestanec in firma.Top3NejvyssiPlat())
            {
                Console.WriteLine(zamestanec);
            }

            Console.WriteLine("\nSeřazení podle data nástupu: ");
            foreach (var zamestanec in firma.SeradPodleNastupu())
            {
                Console.WriteLine(zamestanec);
            }

            Console.WriteLine("\nZaměstnanci kteri maji svatek");
            foreach (var zamestanec in firma.MaSvatek())
            {
                Console.WriteLine(zamestanec);
            }

        }




    }
}
