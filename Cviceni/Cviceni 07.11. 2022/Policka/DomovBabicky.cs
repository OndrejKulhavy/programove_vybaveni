using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Cviceni_07._11._2022.Enums;

namespace Cviceni_07._11._2022.Policka
{
    class DomovBabicky : Policko
    {
        public DomovBabicky() : base(Typ.DOMECEK_BABICKY)
        {

        }

        public override bool SplnUcel()
        {
            if (karkulka.MaDarkyProBabicku() && karkulka.PredbehlJiVlk == false)
            {
                Console.WriteLine("Karkulka vyhrála!");
                Console.Write("     Pro potrvzeni stiskni libovolnou klavesu...");

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Karkulka prohrála!");
                Console.Write("     Pro potrvzeni stiskni libovolnou klavesu...");

                Console.ReadKey();

            }
            return false;

        }
        public override string ToString()
        {
            if (Karkulka != null)
            {
                return "💃";
            }
            return "🏠";
        }

    }
}
