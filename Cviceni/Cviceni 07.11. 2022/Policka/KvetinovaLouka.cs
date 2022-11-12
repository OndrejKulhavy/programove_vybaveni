using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Cviceni_07._11._2022.Enums;

namespace Cviceni_07._11._2022.Policka
{
    class KvetinovaLouka : Policko
    {
        public KvetinovaLouka() : base(Typ.KVETINOVA_LOUKA)
        {

        }

        public override bool SplnUcel()
        {
            if (!karkulka.Sbirala)
            {
                karkulka.Sbirala = true;
                karkulka.PocetDarku = karkulka.PocetDarku + 1;
            }
            else
            {
                Console.WriteLine("Karkulka již sbírala a nemůže sbírat znovu.");
                Console.Write("     Pro potrvzeni stiskni libovolnou klavesu...");
                Console.ReadKey();

            }
            return true;
        }

        public override string ToString()
        {
            if (Karkulka != null)
            {
                return "💃";
            }
            return "🌸";
        }

    }
}
