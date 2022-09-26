using System;

namespace Test_26._09
{
    class Program
    {
        static void Main(string[] args)
        {
            StrelnaZbran zbran = new StrelnaZbran(10, 5);
            Console.WriteLine("Strilim");
            zbran.Vystrel();
            Console.WriteLine(zbran);

            Console.WriteLine("Strilim");
            zbran.Vystrel();
            Console.WriteLine(zbran);

            Console.WriteLine("Strilim");
            zbran.Vystrel();
            Console.WriteLine(zbran);

            Console.WriteLine("Ponicil jsem zbran");
            zbran.Zasekni();
            Console.WriteLine(zbran);

            Console.WriteLine("Strilim");
            zbran.Vystrel();
            Console.WriteLine(zbran);

            Console.WriteLine("Opravuji zbran");
            zbran.Oprav();
            Console.WriteLine(zbran);

            Console.WriteLine("Strilim");
            zbran.Vystrel();
            Console.WriteLine(zbran);

            Console.WriteLine("Strilim");
            zbran.Vystrel();
            Console.WriteLine(zbran);

            Console.WriteLine("Strilim");
            zbran.Vystrel();
            Console.WriteLine(zbran);

        }
    }
}
