using System;

namespace _28_11_2022
{
    class Pokemon
    {
        //vlastnosti
        private TypPokemona typ;
        private string jmeno;

        //get set
        public TypPokemona Typ { get => typ; set => typ = value; }
        public string Jmeno { get => jmeno; set => jmeno = value; }

        //konstruktor
        public Pokemon(TypPokemona typ, string jmeno)
        {
            Typ = typ;
            Jmeno = jmeno;
        }

        public override string ToString()
        {
            return $"Pokemon: {jmeno}, typ: {typ}";
        }
    }
}