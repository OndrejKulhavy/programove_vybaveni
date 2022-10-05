using System;
using System.Collections.Generic;

namespace Cviceni_03._10._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            DruheCviceni();

        }

        public static void PrvniCviceni()
        {

        }

        public static void DruheCviceni()
        {
            List<Uzivatel> users = new List<Uzivatel>();
            users.Add(new Uzivatel("Petr", "1235454456"));
            users.Add(new Uzivatel("Jakub", "fobfeklovb"));
            users.Add(new Uzivatel("Pavel", "123457456"));
            users.Add(new Uzivatel("Bonifác", "1298856"));
            users.Add(new Uzivatel("Lonifác", "1298856"));
            users.Add(new Uzivatel("Aďa", "asjfowpvjb"));

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            users.Sort();
            Console.WriteLine("Pořadí podle nickname");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }

        public static void TretiCviceni()
        {

        }

        public static void CtvrteCviceni()
        {

        }
    }
}
