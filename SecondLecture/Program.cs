using System;

namespace SecondLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Potravina potravina = new Potravina("Jablko", 100, Jednotky.kcal, 100, 500);
            Console.WriteLine(potravina.GetEnergy());
            potravina.ChangeJednotky(Jednotky.kJ);
            Console.WriteLine(potravina.GetEnergy());

            Interval interval = new Interval(1, 5);
            Console.WriteLine(interval.IsIN(3));
            Console.WriteLine(interval.IsIN(6));
            Console.WriteLine(interval.Intersection(new Interval(2, 4)));

            Primka primka = new Primka(1,4);

            Trojuhelnik trojuhelnik = new Trojuhelnik(1,2,3);
            Console.WriteLine(trojuhelnik.IsRovnostranny());
            Console.WriteLine(trojuhelnik.IsRovnoramenny());



        }
    }
}
