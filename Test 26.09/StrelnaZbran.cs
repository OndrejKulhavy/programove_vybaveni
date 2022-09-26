using System;

namespace Test_26._09
{
    class StrelnaZbran
    {
        private int velikostZasobniku;
        private int pocetNaboju;

        private bool zaseknuta = false;

        public int VelikostZasobniku
        {
            get { return velikostZasobniku; }
            set
            {
                if (value > 0)
                    velikostZasobniku = value;
                else
                    throw new Exception("Neplatná velikost zásobníku");
            }
        }

        public int PocetNaboju
        {
            get { return pocetNaboju; }
            set
            {
                if(zaseknuta)
                    return;
                    //throw new Exception("Zbraň je zaseknutá");
                if (value < velikostZasobniku && value >= 0)
                    pocetNaboju = value;
                else
                    throw new Exception("Neplatný počet nábojů");
            }
        }

        public StrelnaZbran(int velikostZasobniku, int pocetNaboju)
        {
            VelikostZasobniku = velikostZasobniku;
            PocetNaboju = pocetNaboju;
        }

        public void Vystrel()
        {
            if (zaseknuta)
            {
                return;
                //throw new Exception("Zbraň je zaseknuta");
            }

            if (pocetNaboju > 0)
            {
                pocetNaboju--;
            }

            else
            {
                throw new Exception("Zásobník je prázdný");
            }

        }

        public void Zasekni()
        {
            zaseknuta = true;
        }

        public void Oprav()
        {
            zaseknuta = false;
        }

        public void NabitNaboje(int pocetNaboju)
        {
            if (zaseknuta)
            {
                return;
                //throw new Exception("Zbraň je zaseknuta");
            }

            if (pocetNaboju + PocetNaboju > VelikostZasobniku)
            {
                throw new Exception("Náboje se nevejdou do zásobníku");
            }

            PocetNaboju += pocetNaboju;
        }
        public override string ToString()
        {
            return "Zbraň se velikostí zásobníku: " + VelikostZasobniku + " a počtem nábojů: " + PocetNaboju + ", je zaseknuta?: " + zaseknuta;
        }
    }
}