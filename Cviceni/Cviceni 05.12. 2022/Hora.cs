using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cviceni_05._12._2022
{
    class Hora
    {
        private string nazev;
        private int vyska;

        //get set
        public string Nazev { get => nazev; set => nazev = value; }
        public int Vyska { get => vyska; set => vyska = value; }
        // Konstruktor
        public Hora(string hory)
        {
            //regex
            Regex regex = new Regex(@"^.*?\([^\d]*(\d+)[^\d]*\).*$");
            Match match = regex.Match(hory);
            nazev = hory.Substring(0, match.Groups[1].Index - 1);
            vyska = int.Parse(match.Groups[1].Value);
        }
        
        public override string ToString()
        {
            return $"{nazev} ({vyska} m.n.m.)";
        }
    }
}
