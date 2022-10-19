using System;
using System.Collections.Generic;

namespace Ukol_17_10_2022
{
    class Slovnik
    {
        List<Slovo> slovnik = new List<Slovo>();

        public List<Slovo> ObsahSlovniku
        {
            get { return slovnik; }
            set { slovnik = value; }
        }
        public void PridejSlovo(Slovo slovo)
        {
            slovnik.Add(slovo);
        }

        public List<string> NajdiSlovo(string slovo, Jazyky jazyk)
        {
            List<string> vysledek = new List<string>();
            foreach (Slovo slovoVListu in slovnik)
            {
                if (jazyk == Jazyky.CESKY)
                {
                    foreach (string ceskeSlovo in slovoVListu.Ceske)
                    {
                        if (ceskeSlovo == slovo)
                        {
                            vysledek = slovoVListu.Anglicke;
                        }
                    }
                }
                else
                {
                    foreach (string anglickeSlovo in slovoVListu.Anglicke)
                    {
                        if (anglickeSlovo == slovo)
                        {
                            vysledek = slovoVListu.Ceske;
                        }
                    }
                }
            }
            return vysledek;
        }

    }
}
