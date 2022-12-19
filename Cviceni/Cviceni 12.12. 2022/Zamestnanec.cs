using System;

namespace Cviceni_12._12._2022
{
    class Zamestanec
    {
        private string jmeno;
        private string prijmeni;
        private int plat;
        private Pozice pozice;
        private DateTime datumNastupu;

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Plat { get; set; }
        public Pozice Pozice { get; set; }
        public DateTime DatumNastupu { get; set; }

        public Zamestanec(string jmeno, string prijmeni, int plat, Pozice pozice, DateTime datumNastupu)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Plat = plat;
            Pozice = pozice;
            DatumNastupu = datumNastupu;
        }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} {Plat} {Pozice} {DatumNastupu}";
        }
        
    }
}
