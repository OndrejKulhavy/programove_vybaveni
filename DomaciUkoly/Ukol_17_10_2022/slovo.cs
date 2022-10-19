using System;
using System.Collections.Generic;

namespace Ukol_17_10_2022
{
    class Slovo
    {
        List<string> ceske = new List<string>();
        List<string> anglicke = new List<string>();
        
        public List<string> Ceske
        {
            get { return ceske; }
            set { ceske = value; }
        }

        public List<string> Anglicke
        {
            get { return anglicke; }
            set { anglicke = value; }
        }

        public Slovo(List<string> ceske, List<string> anglicke)
        {
            Ceske = ceske;
            Anglicke = anglicke;
        }

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
