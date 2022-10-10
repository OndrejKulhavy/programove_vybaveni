using System;

namespace Test_10._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Lod lodHelena = new Lod("Helena", 40);
            Plachetnice plachetniceVlastovka = new Plachetnice("Vlaštovka", 8, true);
            lodHelena.Rychlost = -20;
            Majitel m1 = new Majitel("Jan", "Novák", lodHelena);
            Majitel m2 = new Majitel("Karel", "Sýkora", plachetniceVlastovka);
            Console.WriteLine(m1);
            Console.WriteLine(m2);

            Console.WriteLine("Rychlost plachetnice v km/h: " + plachetniceVlastovka.RychlostKmh);
        }
    }
}
