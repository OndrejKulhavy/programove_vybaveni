using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Cviceni_07._11._2022.Enums;

namespace Cviceni_07._11._2022.Policka
{
    class BludnyKoren : Policko
    {
        Hra hra;
        public BludnyKoren(Hra hra) : base(Typ.BLUDNY_KOREN)
        {
            Hra = hra;
        }

        public Hra Hra { get => hra; set => hra = value; }
        public override bool SplnUcel()
        {
            Console.WriteLine("Bludny koren");
            Console.WriteLine("Budeš přemístěn/a na náhodné políčko o kolo kořene!");
            Console.WriteLine("     Stiskni jakoukoliv klávesu pro pokračování");
            Console.ReadKey();

            Random rnd = new Random();
            int nahodneCislo = rnd.Next(0, 4);
            switch (nahodneCislo)
            {
                case 0:
                    Hra.PohniKarkulkou(Smer.NAHORU);
                    break;
                case 1:
                    Hra.PohniKarkulkou(Smer.DOLU);
                    break;
                case 2:
                    Hra.PohniKarkulkou(Smer.VPRAVO);
                    break;
                case 3:
                    Hra.PohniKarkulkou(Smer.VLEVO);
                    break;
            }

            return true;
        }

        public override string ToString()
        {
            if (Karkulka != null)
            {
                return "💃";
            }
            return "🌳";
        }

    }
}
