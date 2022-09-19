using System;

namespace ThirdLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Clovek clovek = new Clovek("Dominik Procházka", 20);
                Console.WriteLine(clovek);
            }
            Console.WriteLine("--------");
            for (int i = 0; i < 10; i++)
            {
                Politik politik = new Politik("Tokyo Okamura", 50, "SPD");
                Console.WriteLine(politik);
            }
            Console.WriteLine("--------");
            for (int i = 0; i < 10; i++)
            {
                Svetec svetec = new Svetec("Jakub Cesar", 17, "Rak");
                Console.WriteLine(svetec);
            }


            Console.WriteLine("--------");
            Ucet ucet = new Ucet(false, "Dominik Procházka");
            Console.WriteLine(ucet);
            Console.WriteLine("--------");
            UrocenyUcet urocenyUcet = new UrocenyUcet(false, 0.05, "Dominik Procházka");
            Console.WriteLine(urocenyUcet);
            Console.WriteLine("--------");
            PlacenyUrocenyUcet placenyUrocenyUcet = new PlacenyUrocenyUcet(false, 0.05, 100, "Dominik Procházka");
        }
    }
}
