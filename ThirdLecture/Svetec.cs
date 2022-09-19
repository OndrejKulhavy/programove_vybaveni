namespace ThirdLecture
{
    internal class Svetec : Clovek
    {
        private string znameni;

        public Svetec(string jmeno, int vek, string znameni) : base(jmeno, vek)
        {
            Znameni = znameni;
        }

        public string Znameni
        {
            get { return znameni; }
            set { znameni = value; }
        }

        override public bool MluviPravdu()
        {
            return true;
        }
        public override string ToString()
        {
            return base.ToString() + " Znameni: " + Znameni;
        }
    }
}
