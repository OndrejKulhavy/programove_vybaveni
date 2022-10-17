using System;
using System.Collections.Generic;

namespace Cviceni_17._10._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            SeznamUdalosti seznamUdalosti = new SeznamUdalosti();
            seznamUdalosti.PridejUdalost(new Udalost(Typ.APLIKACNI, "Pozorovani", Uroven.INFORMACE));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.SYSTEMOVA, "Pozorovani", Uroven.VAROVANI));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.APLIKACNI, "Pozorovani", Uroven.CHYBA));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.APLIKACNI, "Pozorovani", Uroven.INFORMACE));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.SYSTEMOVA, "Pozorovani", Uroven.VAROVANI));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.HARDWAROVA, "Pozorovani", Uroven.CHYBA));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.APLIKACNI, "Pozorovani", Uroven.INFORMACE));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.SYSTEMOVA, "Pozorovani", Uroven.VAROVANI));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.HARDWAROVA, "Pozorovani", Uroven.CHYBA));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.APLIKACNI, "Pozorovani", Uroven.INFORMACE));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.SYSTEMOVA, "Pozorovani", Uroven.VAROVANI));
            seznamUdalosti.PridejUdalost(new Udalost(Typ.HARDWAROVA, "Pozorovani", Uroven.CHYBA));

            Console.WriteLine("Nefiltrovano");
            Console.WriteLine(seznamUdalosti.ToString());
            Console.WriteLine("Filtrovano");
            Console.WriteLine(seznamUdalosti.FiltrToString(Typ.ANY, Uroven.CHYBA));
        }
    }
}
