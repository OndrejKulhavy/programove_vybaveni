using System;
using System.Collections.Generic;
class DatabazeUzivatelu
{
    private List<Uzivatel> uzivatele;

    public DatabazeUzivatelu()
    {
        uzivatele = new List<Uzivatel>();
    }
    public void PridejUzivatele(Uzivatel uzivatel)
    {
        uzivatele.Add(uzivatel);
    }

    public void VypisUzivatele()
    {
        foreach (Uzivatel uzivatel in uzivatele)
        {
            Console.WriteLine(uzivatel.ToString());
        }
    }

    public void ZmenaJmena(string jmeno, string noveJmeno)
    {
        foreach (Uzivatel uzivatel in uzivatele)
        {
            if (uzivatel.Jmeno == jmeno)
            {
                uzivatel.Jmeno = noveJmeno;
            }
        }
    }
}