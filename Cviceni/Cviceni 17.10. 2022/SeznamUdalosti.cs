using System;
using System.Collections.Generic;
class SeznamUdalosti
{
    private List<Udalost> seznam;

    public List<Udalost> Seznam
    {
        get { return seznam; }
        set { seznam = value; }
    }


    public SeznamUdalosti(List<Udalost> seznam)
    {
        Seznam = seznam;
    }

    public SeznamUdalosti()
    {
        Seznam = new List<Udalost>();
    }

    public void PridejUdalost(Udalost udalost)
    {
        seznam.Add(udalost);
    }

    public List<Udalost> Filtr(Typ typ, Uroven uroven)
    {
        List<Udalost> vysledek = new List<Udalost>();
        foreach (Udalost udalost in seznam)
        {
            if (udalost.Typ == typ && udalost.Uroven == uroven)
            {
                vysledek.Add(udalost);
            }
        }

        return vysledek;
    }

    public override string ToString()
    {
        string vysledek = "";
        foreach (Udalost udalost in seznam)
        {
            vysledek += udalost + ", \n";
        }
        return vysledek;
    }

    public string FiltrToString(Typ typ, Uroven uroven)
    {
        string vysledek = "";
        List<Udalost> seznamFiltr = Filtr(typ, uroven);
        foreach (Udalost udalost in seznamFiltr)
        {
            vysledek += udalost + ", \n";
        }
        return vysledek;
    }
}