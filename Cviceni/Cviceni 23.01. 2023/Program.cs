using System;

namespace Cviceni_23._01._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("1. Register new user");
                Console.WriteLine("2. Log in");
                Console.WriteLine("3. Print all users");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Zadejte volbu: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        database.RegisterNewUser();
                        break;
                    case "2":
                        User user = database.LogIn();
                        break;
                    case "3":
                        database.PrintAllUsers();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Neplatna volba");
                        break;
                }
                database.SaveToFile();
                Console.WriteLine("Stisknete libovolnou klavesu pro pokracovani");
                Console.ReadKey();
            }
        }
    }
}
