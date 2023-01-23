using System;
using System.Collections.Generic;

namespace Cviceni_16._01._2023
{
    class Auto
    {

        private List<Zakaznik> zakaznici;
        private bool jeVolne;

        public string Znacka {get;set;}
        public string Model {get;set;}
        public string SPZ {get;set;}
        public List<Zakaznik> Zakaznici {get;set;}

        public bool JeVolne {get; set;}
        public Auto(string znacka, string model, string spz)
        {
            Znacka = znacka;
            Model = model;
            SPZ = spz;
            JeVolne = true;
            Zakaznici = new List<Zakaznik>();
        }


        public void Vraceno()
        {
            JeVolne = true;
        }

        public void Pujceno(Zakaznik zakaznik)
        {
            Zakaznici.Add(zakaznik);
            JeVolne = false;
        }

        public Zakaznik GetZakaznik()
        {
            return Zakaznici[Zakaznici.Count - 1];
        }

        public override string ToString()
        {
            return $"Znacka: {Znacka}, Model: {Model}, SPZ: {SPZ}, Je volne: {JeVolne}";
        }
    }
}
