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

        private bool hraBezi = true;

        #endregion

        #region Gettery a settery
        public int Velikost
        {
            get { return velikost; }
            set { velikost = value; }
        }

        public bool HraBezi
        {
            get { return hraBezi; }
            set { hraBezi = value; }
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
            PridatSpecialniPolicko(new Vlk());
            PridatSpecialniPolicko(new DomovBabicky());
        }
        #endregion

        #region Metody
        //vytvoreni hraciho pole dle velikosti

        private void VytvorHraciPole()
        {
            Random random = new Random();
            hraciPole = new Policko[velikost, velikost];
            for (int i = 0; i < hraciPole.GetLength(0); i++)
            {
                for (int j = 0; j < hraciPole.GetLength(1); j++)
                {   //na vsechny krajni policka se vlozi policko typu kamen
                    if (i == 0 || i == hraciPole.GetLength(0) - 1 || j == 0 || j == hraciPole.GetLength(1) - 1)
                        hraciPole[i, j] = new Kamen();
                    else
                    {
                        int nahodneCislo = random.Next(0, 10);
                        switch (nahodneCislo)
                        {
                            case 0:
                                hraciPole[i, j] = new Vyhlidka();
                                break;
                            case 1:
                                hraciPole[i, j] = new BludnyKoren(this);
                                break;
                            case 2:
                                hraciPole[i, j] = new KvetinovaLouka();
                                break;
                            case 3:
                                hraciPole[i, j] = new Prekazka();
                                break;
                            default:
                                hraciPole[i, j] = new Vyhlidka();
                                break;
                        }
                    }

                }
            }
        }

        public void PohniKarkulkou(string smer)
        {
            if (smer.Equals("nahoru"))
                PohniKarkulkou(Smer.NAHORU);
            else if (smer.Equals("dolu"))
                PohniKarkulkou(Smer.DOLU);
            else if (smer.Equals("doleva"))
                PohniKarkulkou(Smer.VLEVO);
            else if (smer.Equals("doprava"))
                PohniKarkulkou(Smer.VPRAVO);
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
                        Move(0, -1, karkulka);
                    HraBezi = hraciPole[poziceKarkulkyX, poziceKarkulkyY].SplnUcel();
                    break;
                case Smer.VPRAVO:
                    if (HraciPole[poziceKarkulkyX, poziceKarkulkyY + 1].Typ == Typ.KAMEN)
                        throw new Exception("Karkulka se nemuze pohnout");
                    else
                        Move(0, 1, karkulka);
                    HraBezi = hraciPole[poziceKarkulkyX, poziceKarkulkyY].SplnUcel();

                    break;
                case Smer.NAHORU:
                    if (HraciPole[poziceKarkulkyX - 1, poziceKarkulkyY].Typ == Typ.KAMEN)
                        throw new Exception("Karkulka se nemuze pohnout");
                    else
                        Move(-1, 0, karkulka);
                    HraBezi = hraciPole[poziceKarkulkyX, poziceKarkulkyY].SplnUcel();

                    break;
                case Smer.DOLU:
                    if (HraciPole[poziceKarkulkyX + 1, poziceKarkulkyY].Typ == Typ.KAMEN)
                        throw new Exception("Karkulka se nemuze pohnout");
                    else
                        Move(1, 0, karkulka);
                    HraBezi = hraciPole[poziceKarkulkyX, poziceKarkulkyY].SplnUcel();
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

        private void PridatKarkulku()
        {
            Random random = new Random();
            int x = random.Next(0, velikost);
            int y = random.Next(0, velikost);
            if (!(hraciPole[x, y].Typ == Typ.KAMEN))
            {
                hraciPole[x, y] = new DomovKarkulky();
                hraciPole[x, y].Karkulka = new Karkulka();
                PoziceKarkulkyX = x;
                PoziceKarkulkyY = y;

                Console.WriteLine(hraciPole[x, y].Karkulka);
            }
            else PridatKarkulku();
        }

        private void PridatSpecialniPolicko(Policko policko)
        {
            Random random = new Random();
            int x = random.Next(0, velikost);
            int y = random.Next(0, velikost);
            if (!(hraciPole[x, y].Typ == Typ.KAMEN))
            {
                hraciPole[x, y] = policko;
            }
            else PridatSpecialniPolicko(policko);
        }



        public void Vypis()
        {
            Console.Write("Darky: ");
            int pocetDarku = hraciPole[poziceKarkulkyX, poziceKarkulkyY].Karkulka.PocetDarku;
            for (int i = 0; i < pocetDarku; i++)
            {
                Console.Write("🎁 ");
            }
            Console.WriteLine();
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
