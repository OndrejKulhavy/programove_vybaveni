namespace ThirdLecture
{
    class UrocenyUcet :Ucet
    {
        private double urok;

        public UrocenyUcet(bool karta, double urok, string jmeno) : base(karta, jmeno)
        {
            Urok = urok;
        }

        public double Urok
        {
            get { return urok; }
            set { urok = value; }
        }

        virtual public void ZapisUrok()
        {
            Stav += (Stav * Urok);
        }
    }
}