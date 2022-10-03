using System;

namespace Cviceni_03._10._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
    public static int[] GenerujPole(int dolni, int horni)
    {
        int[] pole = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < pole.Length; i++)
        {
            pole[i] = rnd.Next(dolni, horni++);
        }
        return pole;
    }
    public static void Vypis(int[] pole)
    {
        for (int i = 0; i < pole.Length; i++)
        {
            Console.WriteLine(pole[i]);
        }
    }
    }
}
