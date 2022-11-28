using System;
using System.Collections.Generic;


namespace _28_11_2022
{
    class EvidenceUzivatelu
    {
        private HashSet<Uzivatel> uzivatele;

        //get set
        public HashSet<Uzivatel> Uzivatele { get => uzivatele; set => uzivatele = value; }

        //konstruktor
        public EvidenceUzivatelu()
        {
            Uzivatele = new HashSet<Uzivatel>();
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

        public void VymazUzivatele(Uzivatel uzivatel)
        {
            uzivatele.Remove(uzivatel);
        }

        public void VymazUzivatele(int id)
        {
            foreach (Uzivatel uzivatel in uzivatele)
            {
                if (uzivatel.Id == id)
                {
                    uzivatele.Remove(uzivatel);
                    break;
                }
            }
        }

    }
}