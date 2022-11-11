using System;
namespace ThirdLecture
{
    class Ucet
    {
        private string jmeno;
        private double vklad;
        private double vyber;
        private double stav;

        private Karta karta;

        public Ucet(bool karta, string jmeno)
        {
            Jmeno = jmeno;
            if (karta)
            {
                DateTime date = DateTime.Today;
                Random rnd = new Random();
                long number = (long) rnd.Next(1000000000, 999999999);
                Karta = new Karta(
                    jmeno,
                    number,
                    date.AddYears(2).ToString("MM/yy"),
                    rnd.Next(100, 999).ToString(),
                    this
                );
            }
        }

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        public double Vklad
        {
            get { return vklad; }
            set { vklad = value; }
        }

        public double Vyber
        {
            get { return vyber; }
            set { vyber = value; }
        }

        public double Stav
        {
            get { return stav; }
            set { stav = value; }
        }

        public Karta Karta
        {
            get { return karta; }
            set { karta = value; }
        }

        public void VlozitPenize(double vklad)
        {
            if (vklad > 0)
            {
                stav += vklad;
            }else
            {
                throw new Exception("Nelze vlozit zapornou hodnotu");
            }
        }

        public void VybratPenize(double vyber)
        {
            if (vyber > 0 && (stav - vyber) >= 0)
            {
                stav -= vyber;
            }
            else
            {
                throw new Exception("Nelze vybrat");
            }
        }

    }
}