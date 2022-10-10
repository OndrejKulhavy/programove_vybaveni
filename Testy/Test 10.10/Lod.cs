namespace Test_10._10
{
    class Lod
    {
        private string jmeno;
        private int rychlost;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public int Rychlost
        {
            get { return rychlost; }
            set 
            { 
                if (value > 0) rychlost = value;
                else rychlost = 0;
            }
        }

        public double RychlostKmh
        {
            get { return rychlost * 1.852; }
        }

        public Lod(string jmeno, int rychlost)
        {
            this.jmeno = jmeno;
            this.rychlost = rychlost;
        }

        public override string ToString()
        {
            return "Lod " + jmeno + " má rychlost " + rychlost;
        }
    }
}