using System;
using System.Collections.Generic;

namespace Cviceni_28._11._2022
{
    class Program
    {     
        public delegate int Operation(int a, int b);
        public delegate int MyFunction(int x);

        static void Main(string[] args)
        {
            Operation operation = Add;
            Console.WriteLine(operation(1, 2));

            operation = Sub;
            Console.WriteLine(operation(1, 2));

            operation = Mul;
            Console.WriteLine(operation(1, 2));

            operation = Div;
            Console.WriteLine(operation(1, 2));

            Operation[] operations = new Operation[] { Add, Sub, Mul, Div };

            Console.WriteLine("Vyber co chceš udělat:");
            Console.WriteLine("1 - Sčítání");
            Console.WriteLine("2 - Odčítání");
            Console.WriteLine("3 - Násobení");
            Console.WriteLine("4 - Dělení");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadej první číslo:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadej druhé číslo:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(operations[choice - 1](a, b));


            MyFunction square = x => x * x;
            Console.WriteLine(square(5));

            MyFunction cube = x => x * x * x;
            Console.WriteLine(cube(5));

            MyFunction Signum = x => x > 0 ? 1 : x < 0 ? -1 : 0;

            //MyFunction Factorial = x => x == 0 ? 1 : x * Factorial(x - 1);

            MyFunction[] functions = new MyFunction[] { square, cube, Signum };

            Console.WriteLine("Vyber co chceš udělat:");
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Cube");
            Console.WriteLine("3 - Signum");
            Console.WriteLine("4 - Faktoriál");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadej číslo:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine(functions[choice - 1](a));
            
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
