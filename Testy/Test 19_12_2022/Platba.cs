using System;

namespace Test_19_12_2022
{
    class Platba
    {
        private int ucetOdesilatel;
        private int ucetPrijemce;
        private int id;
        double castka;

        public int UcetOdesilatel { get => ucetOdesilatel; set => ucetOdesilatel = value; }
        public int UcetPrijemce { get => ucetPrijemce; set => ucetPrijemce = value; }
        public int Id
        {
            get => id;
            set
            {
                Random random = new Random();
                id = random.Next(1000, 9999);
            }
        }
        public double Castka { get => castka; set => castka = value; }

        public Platba(int ucetOdesilatel, int ucetPrijemce, double castka)
        {
            Id = id;
            UcetOdesilatel = ucetOdesilatel;
            UcetPrijemce = ucetPrijemce;
            Castka = castka;
        }

        public override string ToString()
        {
            return $"Ucet odesilatel: {UcetOdesilatel}, Ucet prijemce: {UcetPrijemce}, Id: {Id}, Castka: {Castka}";
        }
    }
}
