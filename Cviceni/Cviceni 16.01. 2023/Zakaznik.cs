using System;

namespace Cviceni_16._01._2023
{
    class Zakaznik
    {
        public string Jmeno {get;set;}

        public string Prijmeni {get;set;}

        public string Adresa {get;set;}

        public int Telefon {get;set;}

        public DateTime DatumNarozeni {get;set;}

        public Zakaznik(string jmeno, string prijmeni, string adresa, int telefon, DateTime datumNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Adresa = adresa;
            Telefon = telefon;
            DatumNarozeni = datumNarozeni;
        }

        public override string ToString()
        {
            return $"Jmeno: {Jmeno}, Prijmeni: {Prijmeni}, Adresa: {Adresa}, Telefon: {Telefon}, Datum narozeni: {DatumNarozeni}";
        }
    }
}
