using System;
using System.Collections.Generic;

namespace Cviceni_10._10._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(1, 6));
            }

            LinkedList<int> linkedList = new LinkedList<int>();

            HashSet<int> hashSet = new HashSet<int>();

            SortedSet<int> sortedSet = new SortedSet<int>();


            foreach (int number in numbers)
            {
                linkedList.AddLast(number);
                hashSet.Add(number);
                sortedSet.Add(number);
            }

            Console.WriteLine("List:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("LinkedList:");
            foreach (int number in linkedList)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("HashSet:");
            foreach (int number in hashSet)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("SortedSet:");
            foreach (int number in sortedSet)
            {
                Console.Write(number + " ");
            }


            DatabazeUzivatelu databazeUzivatelu = new DatabazeUzivatelu();
            databazeUzivatelu.PridejUzivatele(new Uzivatel("Jan", "Novak", "1234"));
            databazeUzivatelu.PridejUzivatele(new Uzivatel("Jakub", "Cesar", "OndraJeNejlepsi"));
            databazeUzivatelu.PridejUzivatele(new Uzivatel("Martin", "Kunes", "NebudChudej"));
            databazeUzivatelu.PridejUzivatele(new Uzivatel("Erik", "Bohac", "ChybiMiTetovani"));

            databazeUzivatelu.VypisUzivatele();
        }



    }
}
