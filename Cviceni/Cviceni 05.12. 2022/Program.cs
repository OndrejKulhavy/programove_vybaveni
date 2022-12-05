using System;
using System.Linq;
using System.Collections.Generic;

namespace Cviceni_05._12._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cisla = new List<int>() { -3, 1, 3, -8, 4, 1, 12, 8, -2, 26, 9, -11 };
            string krkonosskeHory = "Sněžka (1603 m) • Luční hora (1555 m) • Studniční hora (1555 m) • Vysoké kolo (1510 m) • Stříbrný hřbet (1490 m) • Violík (1472 m) • Malý Šišák (1440 m) • Kotel (1435 m) • Zadní Planina (1423 m) • Harrachovy kameny (1421 m) • Mužské kameny (1415 m) • Dívčí kameny (1414 m) • Svorová hora (1411 m) • Zlaté návrší (1411 m) • Růžová hora (1393 m) • Liščí hora (1363 m) • Lysá hora (1344 m)• Železný vrch (1321 m) • Stoh (1320 m) • Černá hora (1300 m) • Luboch (1296 m) • Skalní stůl (1284 m) • Světlá (1244 m) • Medvědín (1235 m) • Čihadlo (1216 m) • Plešivec (1209 m) • Přední Planina (1198 m) • Lysečina (1190 m) • Jelení hora (1173 m) • Slatinná stráň (1153 m) • Vlčí hřeben S (1140 m) • Lesní hora (1129 m) • Vlčí hřeben (1124 m) • Vlčí hřeben J (1119 m) • Pěnkavčí vrch (1105 m) • Dlouhý hřeben (1085 m) • Mechovinec (1081 m) • Kraví hora (1072 m) • Mrtvý vrch (1062 m) • Černá skála (1042 m) • Zadní Žalý (1036 m) • Dvorský les (1036 m) • Vlašský vrch (1037 m) • Šeřín (1036 m) • Preislerův kopec (1035 m) • Jelení vrch (1024 m) • Čertova hora (1021 m) • Přední Žalý (1019 m) • Pevnost (1012 m) • Struhadlo (1007 m) • Mravenečník (1005 m) • Javor (1002 m) • Janova skála SZ (1002 m) • Špičák (1001 m)";
            Pohori pohori = new Pohori(krkonosskeHory);
            Console.WriteLine();

            Console.WriteLine(pohori.NejvyssiHora());
            Console.WriteLine();
            Console.WriteLine(pohori.TriNejvyssiHory().Select(h => h.Nazev).Aggregate((a, b) => a + ", " + b));
            Console.WriteLine();

            Console.WriteLine(pohori.PrumerVysky());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(pohori.NazvyHorDleVysky());

            Console.WriteLine(pohori.VyssiNez(1500));


        }
        public static int pocetKladnychCisel(List<int> cisla)
        {
            return cisla.Where(cislo => cislo > 0).Count();
        }
        public static int nejmensiKladneCislo(List<int> cisla)
        {
            return cisla.Where(cislo => cislo > 0).Min();
        }
        public static int nejvetsiSudeCislo(List<int> cisla)
        {
            return cisla.Where(cislo => cislo % 2 == 0).Max();
        }
        public static double aritemetickyPrumer(List<int> cisla)
        {
            return cisla.Average();
        }

        public static List<int> serazeneCisla(List<int> cisla)
        {
            return cisla.OrderBy(cislo => cislo).ToList();
        }
    }
}
