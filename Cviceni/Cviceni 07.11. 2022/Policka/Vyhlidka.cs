using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Cviceni_07._11._2022.Enums;

namespace Cviceni_07._11._2022.Policka
{
    class Vyhlidka : Policko
    {
        public Vyhlidka() : base(Typ.VYHLIDKA)
        {

        }

        public override string ToString()
        {
            if (Karkulka != null)
            {
                return "💃";
            }
            return "🟩";
        }

    }
}
