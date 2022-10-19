using System;
using System.Collections.Generic;

namespace Ukol_17_10_2022
{
    class Slovnik
    {
        List<Slovo> listSlov = new List<Slovo>();

        // get a set pro listSlov
        public List<Slovo> ListSlov
        {
            get { return listSlov; }
            set { listSlov = value; }
        }

        // metoda pro přidání slova do slovníku (listu slov)
        public void PridejSlovo(Slovo slovo)
        {
            listSlov.Add(slovo);
        }

        // metoda pro vyhledání slova v slovníku (listu slov)
        public List<string> NajdiSlovo(string slovo, Jazyk jazyk)
        {
            List<string> vysledek = new List<string>();

            foreach (Slovo slovoVListu in listSlov)
            {
                // pokud je jazyk nastaven na češtinu
                // a slovo je v seznamu českých slov
                // přidej slovo do výsledku
                if (jazyk == Jazyk.cs)
                {
                    foreach (string ceskeSlovo in slovoVListu.Ceske)
                    {
                        if (ceskeSlovo == slovo)
                        {
                            vysledek = slovoVListu.Anglicke;
                        }
                    }
                }
                // pokud je jazyk nastaven na angličtinu
                // a slovo je v seznamu anglických slov
                // přidej slovo do výsledku
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
