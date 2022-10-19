/*
 * Created Date: Wednesday, October 19th 2022, 12:17:27 pm
 * Author: Ondřej Kulhavý
 * 
 * Copyright (c) 2022
 */

using System;
using System.Collections.Generic;

namespace Ukol_17_10_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Slovnik slovnik = new Slovnik();

            // přídání slov do slovníku
            slovnik.PridejSlovo(new Slovo(
                new List<string>() { "auto", "vozidlo" }, 
                new List<string>() { "car", "vehicle" }));

            slovnik.PridejSlovo(new Slovo(
                new List<string>() { "ahoj", "dobrý den" },
                 new List<string>() { "hi", "hello"}));

            slovnik.PridejSlovo(new Slovo(
                new List<string>() { "traktor" }, 
                new List<string>() { "tractor"}));

            slovnik.PridejSlovo(
                new Slovo(
                    new List<string>() { "pivo" },
                    new List<string>() { "beer"}
                ));


            // výpis slovníku
            foreach (Slovo slovo in slovnik.ListSlov)
            {
                Console.WriteLine(slovo);
            }


            /*---- vyhledávání překladu slova ----*/

            // Najde anglické slovo "hi" a vypíše české překlady
            Console.WriteLine("Nalezeno: ");
            foreach (string slovo in slovnik.NajdiSlovo("hi", Jazyk.en))
            {
                Console.WriteLine(slovo);
            }

            // Najde české slovo "vozidlo" a vypíše anglické překlady
            Console.WriteLine("Nalezeno: ");
            foreach (string slovo in slovnik.NajdiSlovo("vozidlo", Jazyk.cs))
            {
                Console.WriteLine(slovo);
            }
        }
    }
}
