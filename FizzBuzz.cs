using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Fizz");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Buzz");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--------");
            Console.ResetColor();

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{i}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Fizz");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Buzz");
                }

                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i} - Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i} - Buzz");
                }
                
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(i);
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--------");
            Console.ResetColor();
            Console.ReadKey(intercept: true);
        }
    }
}
