using System;
using System.Collections.Generic;

namespace Cviceni_16._01._2023
{
    class Pujcovna
    {
        private List<Auto> auta;

        public List<Auto> Auta {get;set;}

        public Pujcovna()
        {
            Auta = new List<Auto>();
        }

        public void AddAuto(Auto auto)
        {
            Auta.Add(auto);
        }

        public void RemoveAuto(Auto auto)
        {
            Auta.Remove(auto);
        }

        public void PujcAuto(Zakaznik zakaznik, Auto auto)
        {
            if (auto.JeVolne)
                auto.Pujceno(zakaznik);
            else
                throw new Exception("Auto je obsazene");
        }

        public void VratAuto(Auto auto)
        {
            if (!auto.JeVolne)
                auto.Vraceno();
            else
                throw new Exception("Auto je jiz volne");
        }

    }
}
