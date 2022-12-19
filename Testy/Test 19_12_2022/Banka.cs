using System;
using System.Collections.Generic;
using System.Linq;


namespace Test_19_12_2022
{
    class Banka
    {
        private List<Platba> platby = new List<Platba>();

        public List<Platba> Platby { get => platby; set => platby = value; }

        public Banka(){}

        public void PridatPlatbu(Platba platba)
        {
            Platby.Add(platba);
        }

        public double GetCelkovaCastka()
        { 
            return Platby.Sum(x => x.Castka);
        }

        public List<int> GetUcetTopTriPlatby()
        {
            return Platby.OrderByDescending(x => x.Castka).Take(3).Select(x => x.UcetOdesilatel).ToList();
        }

        public List<Platba> GetSerezeneDleVyssePlateb(){
            return Platby.OrderByDescending(x => x.Castka).ToList();
        }


        public List<string> GetCelkoveCastkyProvedeneUcty()
        {
            return Platby
            .GroupBy(x => x.UcetOdesilatel)
            .OrderByDescending(x => x.Sum(y => y.Castka))
            .Select(x => "Ucet odesilatel: " + x.Key + ", Soucet plateb: " + x.Sum(y => y.Castka))
            .ToList();
        }


    }
}
