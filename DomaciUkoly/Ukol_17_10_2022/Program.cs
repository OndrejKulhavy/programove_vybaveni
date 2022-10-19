using System;
using System.Collections.Generic;

namespace Ukol_17_10_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Slovnik slovnik = new Slovnik();
            slovnik.PridejSlovo(new Slovo(new List<string>() { "auto", "vozidlo" }, new List<string>() { "car", "vehicle" }));
            slovnik.PridejSlovo(new Slovo(new List<string>() { "ahoj", "dobrý den" }, new List<string>() { "hi", "hello", "good day" }));

            foreach (Slovo slovo in slovnik.ObsahSlovniku)
            {
                Console.WriteLine(slovo);
            }

            Console.WriteLine("Nalezeno: " + slovnik.NajdiSlovo("car", Jazyky.ANGLICKY)[0]);
        }
    }
}
