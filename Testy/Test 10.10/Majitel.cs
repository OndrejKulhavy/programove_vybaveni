namespace Test_10._10
{
    class Majitel 
    {
        private string jmeno;
        private string prijmeni;
        private Lod lod;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }

        public Lod Lod
        {
            get { return lod; }
            set { lod = value; }
        }

        public Majitel(string jmeno, string prijmeni, Lod lod)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Lod = lod;
        }

        public override string ToString()
        {
            return "Majitel " + Jmeno + " " + Prijmeni + " má lod " + Lod;
        }

    }
}