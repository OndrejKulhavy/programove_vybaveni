using System;

namespace ThirdLecture
{
    internal class Clovek
    {
        private string jmeno;
        private int vek;
        public Clovek(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public int Vek
        {
            get { return vek; }
            set { vek = value; }
        }
        virtual public bool MluviPravdu()
        {
            switch (new Random().Next(0, 2))
            {
                case 0:
                    return true;
                case 1:
                    return false;
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return "Jmeno: " + Jmeno + " Vek: " + Vek + " Mluvi pravdu: " + MluviPravdu();
        }

    }
}
