namespace ThirdLecture
{
    class PlacenyUrocenyUcet :UrocenyUcet
    {
        private double poplatek;

        public PlacenyUrocenyUcet(bool karta, double urok, double poplatek, string jmeno) : base(karta,urok, jmeno)
        {
            Poplatek = poplatek;
        }

        public double Poplatek
        {
            get { return poplatek; }
            set { poplatek = value; }
        }

        public override void ZapisUrok()
        {
            Stav += (Stav * Urok);
            Stav -= Poplatek;
        }
    }
}