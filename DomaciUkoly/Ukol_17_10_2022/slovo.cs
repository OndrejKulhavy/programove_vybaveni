using System;
using System.Collections.Generic;

namespace Ukol_17_10_2022
{
    class Slovo
    {
        List<string> ceske = new List<string>();
        List<string> anglicke = new List<string>();
        

        // get a set pro list českých slov
        public List<string> Ceske
        {
            get { return ceske; }
            set
            {
                if (value.Count > 0) ceske = value;
                else throw new Exception("Slovo musí mít minimálně jeden český překlad");
            }
        }

        // get a set pro list anglických slov
        public List<string> Anglicke
        {
            get { return anglicke; }
            set
            {
                if (value.Count > 0) anglicke = value;
                else throw new Exception("Slovo musí mít minimálně jeden anglický překlad");
            }
        }

        // konstruktor pro slovo
        public Slovo(List<string> ceske, List<string> anglicke)
        {
            Ceske = ceske;
            Anglicke = anglicke;
        }

        // vypsání slova a jeho různé překlady
        public override string ToString()
        {
            string vystup = "";
            foreach (string slovo in ceske)
            {
                vystup += slovo + ", ";
            }
            vystup += " - ";
            foreach (string slovo in anglicke)
            {
                vystup += slovo + ", ";
            }
            return vystup;
        }

    }
}
