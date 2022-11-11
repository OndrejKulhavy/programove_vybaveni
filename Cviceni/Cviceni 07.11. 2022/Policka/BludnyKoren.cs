using Cviceni_07._11._2022.Enums;
using Cviceni_07._11._2022.Policka;
using System;
using System.Collections.Generic;

namespace Cviceni_07._11._2022.Policka
{
    class BludnyKoren : Policko
    {
        private List<QandA> otazkyAodovedi = new List<QandA>();
        public BludnyKoren() : base(Typ.BLUDNY_KOREN)
        {
            otazkyAodovedi.Add(new QandA("Kolik je 2+2?", "4"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+3?", "5"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+4?", "6"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+5?", "7"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+6?", "8"));
            otazkyAodovedi.Add(new QandA("Kolik je 2+7?", "9"));
        }

        public override void SplnUcel()
        {
            Random random = new Random();
            int index = random.Next(0, otazkyAodovedi.Count);
            Console.WriteLine("Bludny koren");
            Console.WriteLine("Otazka: " + otazkyAodovedi[index].Question);
            string odpoved = Console.ReadLine();
            if (odpoved == otazkyAodovedi[index].Answer)
            {
                Console.WriteLine("Spravna odpoved");
                otazkyAodovedi.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Spatna odpoved");
            }
        }

        public override string ToString()
        {
            if (Karkulka != null)
            {
                return "💃";
            }
            return "🌲";
        }
    }
}
