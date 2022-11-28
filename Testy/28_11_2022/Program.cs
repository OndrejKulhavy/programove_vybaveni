using System;

namespace _28_11_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Evidence uživatelů 1.část
            Console.WriteLine("Evidence uživatelů 1.část:");
            EvidenceUzivatelu evidenceUzivatelu = new EvidenceUzivatelu();
            evidenceUzivatelu.PridejUzivatele(new Uzivatel("Petr", "123", 1));
            evidenceUzivatelu.PridejUzivatele(new Uzivatel("Petr", "123", 1));
            evidenceUzivatelu.PridejUzivatele(new Uzivatel("Franta", "123", 3));
            evidenceUzivatelu.VypisUzivatele();

            //Pokemoni 2.část
            Console.WriteLine("Pokemoni 2.část:");
            Console.WriteLine();
            Trener trener = new Trener("Petr", "Novák");
            trener.PridejPokemona(new Pokemon(TypPokemona.Kamenny, "Pikachu"));
            trener.PridejPokemona(new Pokemon(TypPokemona.Ohnivy, "Raichu"));
            trener.PridejPokemona(new Pokemon(TypPokemona.Kamenny, "Onix"));
            trener.PridejPokemona(new Pokemon(TypPokemona.Ocel, "Onix"));
            trener.PridejPokemona(new Pokemon(TypPokemona.Kamenny, "Onix"));

            Console.WriteLine("Vypis vsech pokemonu:");
            trener.VypisPokemony();
            Console.WriteLine();
            Console.WriteLine("Vypis pokemonu typu Kamenny:");
            trener.VypisPokemony(TypPokemona.Kamenny);
            Console.WriteLine();
            Console.WriteLine("Pokemony typu kamenný:");

            Pokemon[] pokesove = trener.GetPokemony(TypPokemona.Kamenny);
            foreach (Pokemon pokemon in pokesove)
            {
                Console.WriteLine(pokemon.ToString());
            }
        }
    }
}
