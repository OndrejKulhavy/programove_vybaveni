using System;
using System.Collections.Generic;
using System.Text.Json;


namespace Cviceni_16._01._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Skoda", "Octavia", "1A2B3C");
            Console.WriteLine(auto1);
            Auto auto2 = new Auto("Skoda", "Fabia", "4D5E6F");
            Console.WriteLine(auto2);
            Auto auto3 = new Auto("Skoda", "Superb", "7G8H9I");
            Console.WriteLine(auto3);

            Zakaznik zakaznik1 = new Zakaznik("Jan", "Novak", "Ulice 1", 123456789, new DateTime(1990, 1, 1));
            Console.WriteLine(zakaznik1);
            Zakaznik zakaznik2 = new Zakaznik("Petr", "Novak", "Ulice 2", 123456789, new DateTime(1990, 1, 1));
            Console.WriteLine(zakaznik2);
            Zakaznik zakaznik3 = new Zakaznik("Jan", "Novak", "Ulice 3", 123456789, new DateTime(1990, 1, 1));
            Console.WriteLine(zakaznik3);

            Pujcovna pujcovna = new Pujcovna();
            pujcovna.AddAuto(auto1);
            pujcovna.AddAuto(auto2);
            pujcovna.AddAuto(auto3);

            pujcovna.PujcAuto(zakaznik1, auto1);
            pujcovna.VratAuto(auto1);
            pujcovna.PujcAuto(zakaznik2, auto1);
            pujcovna.VratAuto(auto1);
            pujcovna.PujcAuto(zakaznik3, auto1);
            pujcovna.VratAuto(auto1);
            Console.WriteLine(auto1);

            pujcovna.PujcAuto(zakaznik2, auto2);
            Console.WriteLine(auto2);

            pujcovna.PujcAuto(zakaznik3, auto3);
            Console.WriteLine(auto3);

            pujcovna.VratAuto(auto2);
            Console.WriteLine(auto2);

            pujcovna.VratAuto(auto3);
            Console.WriteLine(auto3);

            //serializace
            string json = JsonSerializer.Serialize(pujcovna);
            //write to file
            System.IO.File.WriteAllText(@"D:\Quick access\Plocha\WriteText.json", json);
        }
    }
}
