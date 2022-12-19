using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
namespace Cviceni_12._12._2022
{
    class Firma
    {
        private List<Zamestanec> zamestnanci = new List<Zamestanec>();
        private string nazev;

        public string Nazev { get; set; }
        public List<Zamestanec> Zamestnanci { get; set; }

        public Firma(string nazev)
        {
            Nazev = nazev;
        }
        public Firma(string nazev, List<Zamestanec> zamestnanci)
        {
            Nazev = nazev;
            Zamestnanci = zamestnanci;
        }

        public void PridejZamestnance(Zamestanec zamestanec)
        {
            zamestnanci.Add(zamestanec);
        }

        public List<Zamestanec> NejvyssiPlat()
        {
            int max = zamestnanci.Max(z => z.Plat);
            return zamestnanci.Where(z => z.Plat == max).ToList();
        }

        public double PrumerPlatu()
        {
            return zamestnanci.Average(z => z.Plat);
        }

        public double PrumerPlatu(Pozice pozice)
        {
            return zamestnanci.Where(z => z.Pozice == pozice).Average(z => z.Plat);
        }

        public List<Zamestanec> Top3NejvyssiPlat()
        {
            return zamestnanci.OrderByDescending(z => z.Plat).Take(3).ToList();
        }

        public List<Zamestanec> SeradPodleNastupu()
        {
            return zamestnanci.OrderBy(z => z.DatumNastupu).ToList();
        }

        public List<Zamestanec> MaSvatek(string jmeno)
        {
            return zamestnanci.Where(z => z.Jmeno == jmeno).ToList();
        }
        public List<Zamestanec> MaSvatek()
        {
            List<string> jmena = GetDnesniSvatek();

            return zamestnanci.Where(z => jmena.Contains(z.Jmeno)).ToList();

        }

        private List<string> GetDnesniSvatek()
        {
            string url = "https://svatky.adresa.info/xml";
            string xml = "";
            using (var client = new System.Net.WebClient())
            {
                xml = client.DownloadString(url);
            }
            var documet = new XmlDocument();
            documet.LoadXml(xml);
            var nodes = documet.SelectNodes("/svatky/svatek");

            List<string> jmena = new List<string>();
            foreach (System.Xml.XmlNode node in nodes)
            {
                jmena.Add(node.ChildNodes[1].InnerText);
            }

            return jmena;
        }
    }
}
