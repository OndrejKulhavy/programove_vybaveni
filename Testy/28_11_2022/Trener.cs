using System;
using System.Collections.Generic;

namespace _28_11_2022
{
    class Trener
    {
        //vlastnosti
        private string jmeno;
        private string prijmeni;
        private List<Pokemon> pokemoni;

        //get set
        public string Jmeno { get => jmeno; set => jmeno = value; }
        public string Prijmeni { get => prijmeni; set => prijmeni = value; }
        public List<Pokemon> Pokemoni { get => pokemoni; set => pokemoni = value; }

        //konstruktor
        public Trener(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Pokemoni = new List<Pokemon>();
        }

        public void PridejPokemona(Pokemon pokemon)
        {
            Pokemoni.Add(pokemon);
        }

        public void VypisPokemony()
        {
            foreach (Pokemon pokemon in Pokemoni)
            {
                Console.WriteLine(pokemon.ToString());
            }
        }

        public void VypisPokemony(TypPokemona typ)
        {
            foreach (Pokemon pokemon in Pokemoni)
            {
                if (pokemon.Typ == typ)
                {
                    Console.WriteLine(pokemon.ToString());
                }
            }
        }

        public Pokemon[] GetPokemony(TypPokemona typ)
        {
            List<Pokemon> pokemony = new List<Pokemon>();
            foreach (Pokemon pokemon in Pokemoni)
            {
                if (pokemon.Typ == typ)
                {
                    pokemony.Add(pokemon);
                }
            }
            return pokemony.ToArray();
        }

        public void VymazPokemona(Pokemon pokemon)
        {
            Pokemoni.Remove(pokemon);
        }

    }
}