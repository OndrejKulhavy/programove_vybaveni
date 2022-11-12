using System;

namespace Cviceni_07._11._2022
{
    class Karkulka
    {
        #region Vlastnosti

        private bool sbirala = false;

        private int pocetDarku = 2;

        private bool predbehlJiVlk = false;

        #endregion

        #region Konstruktory
        public Karkulka() { }
        #endregion

        #region Gettery a settery

        public bool Sbirala
        {
            get => sbirala;
            set => sbirala = value;
        }

        public bool PredbehlJiVlk
        {
            get => predbehlJiVlk;
            set => predbehlJiVlk = value;
        }

        public int PocetDarku
        {
            get => pocetDarku;
            set => pocetDarku = value;
        }

        #endregion

        #region Metody

        //metoda, která vrátí true, pokud má karkulka dárek
        public bool MaDarek()
        {
            if (pocetDarku > 0)
            {
                return true;
            }
            else return false;
        }

        public bool MaDarkyProBabicku()
        {
            if (pocetDarku > 1)
            {
                return true;
            }
            else return false;
        }

        public void PotkalaVlka()
        {
            if (sbirala)
            {
                predbehlJiVlk = true;
            }
        }

        public void OdeberDarek()
        {
            if (pocetDarku > 0)
            {
                pocetDarku = pocetDarku - 1;
            }
            else
            {
                throw new Exception("Karkulka nemá dárek.");
            }
        }


        public override string ToString()
        {
            return "Karkulka má " + pocetDarku + " dárky.";
        }
        #endregion
    }

}
