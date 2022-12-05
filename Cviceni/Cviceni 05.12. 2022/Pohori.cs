using System;
using System.Linq;
using System.Collections.Generic;

namespace Cviceni_05._12._2022
{
    class Pohori
    {
        private List<Hora> pohori;

        // Konstruktor
        public Pohori(string hory)
        {
            pohori = hory.Split("•").Select(h => new Hora(h)).ToList();
        }

        public Hora NejvyssiHora()
        {
            return pohori.OrderByDescending(h => h.Vyska).First();
        }

        public List<Hora> TriNejvyssiHory()
        {
            return pohori.OrderByDescending(h => h.Vyska).Take(3).ToList();
        }

        public double PrumerVysky()
        {
            return pohori.Average(h => h.Vyska);
        }

        public List<string> NazvyHorDleVysky()
        {
            //sort by vyska
            List<string> vysledky = pohori.OrderBy(h => h.Vyska).Select(h => h.Nazev).ToList();
            string vysledek = "";
            foreach (string item in vysledky)
            {
                vysledek += item + ", ";
            }
            return vysledky;
        }

        public List<Hora> VyssiNez(int vyska)
        {
            return pohori.Where(h => h.Vyska > vyska).ToList();
        }
    }
}
