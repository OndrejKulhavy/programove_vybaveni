using System;

namespace Cviceni_07._11._2022
{
    class Karkulka
    {
        #region Vlastnosti
        private bool maBabovku = true;
        private bool maVino = true;

        private bool sbirala = false;

        private bool maKytkuNeboHoubu = false;

        #endregion
        
        #region Konstruktory
        public Karkulka() { }
        #endregion

        #region Gettery a settery
        public bool MaBabovku
        {
            get => maBabovku;
            set => maBabovku = value;
        }

        public bool MaVino
        {
            get => maVino;
            set => maVino = value;
        }

        public bool Sbirala
        {
            get => sbirala;
            set => sbirala = value;
        }
        
        #endregion

        #region Metody

        //metoda pro sbirani
        public bool Sbirej()
        {
            //když má babovku a vino a sbírala je false, tak se sbírala nastaví na true
            if (MaDarek() && !Sbirala)
            {
                Sbirala = true;
                return true;
            }
            else return false;

        }

        //metoda, která vrátí true, pokud má karkulka dárek
        public bool MaDarek()
        {
            if (maKytkuNeboHoubu || maBabovku || maVino) return true;
            else return false;
        }


        public override string ToString()
        {
            return "Karkulka ma babovku: " + maBabovku + " a vino: " + maVino;
        }
        #endregion
    }

}
