using System;

namespace _28_11_2022
{
    class Uzivatel
    {
        // Vlastnosti
        private string uzivatelskeJmeno;
        private string heslo;
        private int id;

        //get a set
        public string UzivatelskeJmeno { get => uzivatelskeJmeno; set => uzivatelskeJmeno = value; }
        public string Heslo { get => heslo; set => heslo = value; }
        public int Id { get => id; set => id = value; }

        // Konstruktor

        public Uzivatel(string uzivatelskeJmeno, string heslo, int id)
        {
            UzivatelskeJmeno = uzivatelskeJmeno;
            Heslo = heslo;
            Id = id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(uzivatelskeJmeno, id);
        }


        public override bool Equals(object obj)
        {
            return obj is Uzivatel uzivatel &&
                   uzivatelskeJmeno == uzivatel.uzivatelskeJmeno &&
                   id == uzivatel.id;
        }

        public int CompareTo(Uzivatel other)
        {
            return this.UzivatelskeJmeno.CompareTo(other.UzivatelskeJmeno);
        }


        public override string ToString()
        {
            return $"Uzivatel: {uzivatelskeJmeno}, id: {id}";
        }
    }
}