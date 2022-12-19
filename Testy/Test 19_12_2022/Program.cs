using System;

namespace Test_19_12_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Banka banka = new Banka();
            banka.PridatPlatbu(new Platba(123456, 654321, 1000));
            banka.PridatPlatbu(new Platba(158489, 546215, 2000));
            banka.PridatPlatbu(new Platba(158489, 546215, 2000));
            banka.PridatPlatbu(new Platba(158489, 546215, 2000));
            banka.PridatPlatbu(new Platba(156334, 168663, 3000));

            Console.WriteLine("\nCelkova castka: ");
            Console.WriteLine(banka.GetCelkovaCastka());


            Console.WriteLine("\nUcet top tri platby: ");
            foreach (var item in banka.GetUcetTopTriPlatby())
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nSerezene dle vysse plateb: ");
            foreach (var item in banka.GetSerezeneDleVyssePlateb())
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("\nUcty dle vysse plateb: ");
            foreach (var item in banka.GetCelkoveCastkyProvedeneUcty())
            {
                Console.WriteLine(item);
            }
        }
    }
}
