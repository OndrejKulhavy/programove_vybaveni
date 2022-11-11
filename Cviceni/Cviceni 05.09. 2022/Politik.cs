namespace ThirdLecture
{
    internal class Politik : Clovek
    {
        private string strana;
        public Politik(string jmeno, int vek, string strana) : base(jmeno, vek)
        {
            Strana = strana;
        }
        public string Strana
        {
            get { return strana; }
            set { strana = value; }
        }
        override public bool MluviPravdu()
        {
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + " Strana: " + Strana;
        }
    }
}
