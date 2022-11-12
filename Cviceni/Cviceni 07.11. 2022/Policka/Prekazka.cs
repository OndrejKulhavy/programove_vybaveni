using Cviceni_07._11._2022.Enums;
using Cviceni_07._11._2022.Policka;
using System;
using System.Collections.Generic;

namespace Cviceni_07._11._2022.Policka
{
    class Prekazka : Policko
    {
        private List<QandA> otazkyAodovedi = new List<QandA>();
        public Prekazka() : base(Typ.PREZKAZKA)
        {
            otazkyAodovedi.Add(new QandA("Kolik je 2+2?", "4"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+3?", "5"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+4?", "6"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+5?", "7"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+6?", "8"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+7?", "9"));
        }

        public override bool SplnUcel()
        {
            Random random = new Random();
            int index = random.Next(0, otazkyAodovedi.Count);
            Console.WriteLine("Překážka");
            Console.WriteLine("Otazka: " + otazkyAodovedi[index].Question);
            string odpoved = Console.ReadLine();
            if (odpoved == otazkyAodovedi[index].Answer)
            {
                Console.WriteLine("Spravna odpoved");
                Console.Write("     Pro potrvzeni stiskni libovolnou klavesu...");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Spatna odpoved");
                if (karkulka.MaDarek())
                {
                    Console.WriteLine("Karkulka ztratila dárek");
                    karkulka.OdeberDarek();
                    Console.Write("     Pro potrvzeni stiskni libovolnou klavesu...");
                    Console.ReadKey();

                }
            }
            return true;

        }

        public override string ToString()
        {
            if (Karkulka != null)
            {
                return "💃";
            }
            return "🧱";
        }
    }
}
