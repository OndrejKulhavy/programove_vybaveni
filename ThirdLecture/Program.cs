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

        }
    }
}
