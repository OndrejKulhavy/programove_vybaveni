using System;
using Cviceni_07._11._2022.Enums;
using Cviceni_07._11._2022.Policka;

namespace Cviceni_07._11._2022
{

    class Hra
    {

        #region Vlastnosti
        private Policko[,] hraciPole;

        private int poziceKarkulkyX;
        private int poziceKarkulkyY;

        private int velikost = 16;

        #endregion

        #region Gettery a settery
        public int Velikost
        {
            get { return velikost; }
            set { velikost = value; }
        }

        public int PoziceKarkulkyX
        {
            get { return poziceKarkulkyX; }
            set { poziceKarkulkyX = value; }
        }

        public int PoziceKarkulkyY
        {
            get { return poziceKarkulkyY; }
            set { poziceKarkulkyY = value; }
        }

        public Policko[,] HraciPole
        {
            get => hraciPole;
            set => hraciPole = value;
        }
        #endregion

        #region Konstruktory
        public Hra()
        {
            VytvorHraciPole();
            PridatKarkulku();
        }
        #endregion

        #region Metody
        //vytvoreni hraciho pole dle velikosti

        private void VytvorHraciPole()
        {
            hraciPole = new Policko[velikost, velikost];
            for (int i = 0; i < hraciPole.GetLength(0); i++)
            {
                for (int j = 0; j < hraciPole.GetLength(1); j++)
                {   //na vsechny krajni policka se vlozi policko typu kamen
                    if (i == 0 || i == hraciPole.GetLength(0) - 1 || j == 0 || j == hraciPole.GetLength(1) - 1)
                        hraciPole[i, j] = new Policko(Typ.KAMEN);
                    else
                        hraciPole[i, j] = new Policko(Typ.VYHLIDKA);
                }
            }
        }

        public void PohniKarkulkou(Smer smer)
        {
            //zkopirovani karkulky
            Karkulka karkulka = hraciPole[poziceKarkulkyX, poziceKarkulkyY].Karkulka;
            switch (smer)
            {
                case Smer.VLEVO:
                    if (HraciPole[poziceKarkulkyX, poziceKarkulkyY - 1].Typ == Typ.KAMEN)
                        throw new Exception("Karkulka se nemuze pohnout"); //karkulka je stuck
                    else
                        Move(0,-1,karkulka);
                    break;
                case Smer.VPRAVO:
                    if (HraciPole[poziceKarkulkyX, poziceKarkulkyY + 1].Typ == Typ.KAMEN)
                        throw new Exception("Karkulka se nemuze pohnout");
                    else
                        Move(0,1, karkulka);
                    break;
                case Smer.NAHORU:
                    if (HraciPole[poziceKarkulkyX - 1, poziceKarkulkyY].Typ == Typ.KAMEN)
                        throw new Exception("Karkulka se nemuze pohnout");
                    else
                        Move(-1,0, karkulka);
                    break;
                case Smer.DOLU:
                    if (HraciPole[poziceKarkulkyX + 1, poziceKarkulkyY].Typ == Typ.KAMEN)
                        throw new Exception("Karkulka se nemuze pohnout");
                    else
                        Move(1,0, karkulka);
                    break;
                default:
                    throw new Exception("Neznamy smer");
            }
        }

        private void Move(int x, int y, Karkulka karkulka)
        {
            //vymazani karkulky na stare pozici
            hraciPole[poziceKarkulkyX, poziceKarkulkyY].Karkulka = null;
            //zmenseni souradnice x o -1
            poziceKarkulkyY = poziceKarkulkyY + y;
            poziceKarkulkyX = poziceKarkulkyX + x;
            //pridani karkulky na novou pozici
            hraciPole[poziceKarkulkyX, poziceKarkulkyY].Karkulka = karkulka;
        }

        public void PridatSpecialniPolicko(Typ typ)
        {
            Random random = new Random();
            int x = random.Next(0, velikost);
            int y = random.Next(0, velikost);
            //ohlida zda se nevytvori specialni policko na jiz existujicim specialnim poli
            if (HraciPole[x, y].Typ == Typ.VYHLIDKA) HraciPole[x, y].Typ = typ;
            else PridatSpecialniPolicko(typ);
        }

        private void PridatKarkulku()
        {
            Random random = new Random();
            int x = random.Next(0, velikost);
            int y = random.Next(0, velikost);
            if (!(hraciPole[x, y].Typ == Typ.KAMEN))
            {
                hraciPole[x, y].Typ = Typ.DOMECEK_KARKULKY;
                hraciPole[x, y].Karkulka = new Karkulka();
                PoziceKarkulkyX = x;
                PoziceKarkulkyY = y;

                Console.WriteLine(hraciPole[x, y].Karkulka);
            }
            else PridatKarkulku();
        }



        public void Vypis()
        {
            for (int i = 0; i < hraciPole.GetLength(0); i++)
            {
                for (int j = 0; j < hraciPole.GetLength(1); j++)
                {
                    Console.Write(hraciPole[i, j]);
                }
                Console.WriteLine();
            }
        }
        #endregion

    }
}
