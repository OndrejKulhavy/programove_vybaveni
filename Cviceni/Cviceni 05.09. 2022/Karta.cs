namespace ThirdLecture
{
    class Karta
    {
        private Ucet ucet;
        private string jmeno;
        private long cisloKarty;
        private string platnost;
        private string cvc;

        private int limit = 1000;

        public Karta(string jmeno, long cisloKarty, string platnost, string cvc, Ucet ucet)
        {
            Jmeno = jmeno;
            CisloKarty = cisloKarty;
            Platnost = platnost;
            Cvc = cvc;
            Ucet = ucet;
        }

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public long CisloKarty
        {
            get { return cisloKarty; }
            set { cisloKarty = value; }
        }

        public string Platnost
        {
            get { return platnost; }
            set { platnost = value; }
        }

        public string Cvc
        {
            get { return cvc; }
            set { cvc = value; }
        }

        public Ucet Ucet
        {
            get { return ucet; }
            set { ucet = value; }
        }

        public int Limit
        {
            get { return limit; }
        }
        
        public void zmenitLimit(int limit)
        {
            this.limit = limit;
        }

    }
}