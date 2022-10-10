namespace Test_10._10
{
    class Plachetnice : Lod
    {
        bool napnutePlachty;

        public bool NapnutePlachty
        {
            get { return napnutePlachty; }
            set { napnutePlachty = value; }
        }

        public Plachetnice(string jmeno, int rychlost, bool napnutePlachty) : base(jmeno, rychlost)
        {
            NapnutePlachty = napnutePlachty;
        }
        public override string ToString()
        {
            return "Plachetnice " + Jmeno + " má rychlost " + Rychlost + " a plachty jsou napnuté: " + NapnutePlachty;
        }
    }
    
}