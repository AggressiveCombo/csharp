using System;

namespace PiSim
{
    class Program
    {
        private const string pi = "31415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679";

        static void Main()
        {
            Console.Clear();
            int correctDigits = 0;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("You may or may not enter '.' or ',' after the first digit. // Up to 100 decimals.");
            Console.ResetColor();
            Console.WriteLine("Welcome to PiSim.");
            Console.WriteLine("Enter as many digits of pi you know!");
            Console.Write("> ");
            string userPi = Console.ReadLine();

            userPi = userPi.Trim();

            if (string.IsNullOrEmpty(userPi))
            {
                Console.Write("Please enter something.");
                Console.ReadKey(intercept: true);
                Main();
            }

            userPi = userPi.Replace(".", "").Replace(",", "");

            Console.WriteLine();

            for (int i = 0; i < Math.Min(userPi.Length, pi.Length); i++)
            {
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(".");
                    Console.ResetColor();
                }

                if (userPi[i] == pi[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(userPi[i]);
                    Console.ResetColor();
                    correctDigits++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(userPi[i]);
                    Console.ResetColor();
                }
            }
            Console.WriteLine();

            for (int i = 0; i < Math.Min(userPi.Length, pi.Length); i++)
            {
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(".");
                    Console.ResetColor();
                }
                Console.Write(pi[i]);
            }

            if (userPi.Length <= 100)
            {
                for (int i = userPi.Length; i < 100; i++)
                {
                    if (i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(".");
                        Console.ResetColor();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(pi[i]);
                    Console.ResetColor();
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("...");
            Console.ResetColor();

            Console.WriteLine();
            if (correctDigits > 1) { Console.WriteLine($"You've gotten {correctDigits} correct digits! ({correctDigits - 1} decimals)"); }
            else if (correctDigits == 1) { Console.WriteLine($"You've gotten {correctDigits} correct digit! ({correctDigits - 1} decimals)"); }
            else { Console.WriteLine("You've gotten no digits correct!"); }

            Console.WriteLine("\nWould you like to try again? (y/n)");
            Console.Write("> ");
            string retry = Console.ReadLine().Trim().ToLower();
            if (retry == "y")
            {
                Main();
            }
            Environment.Exit(0);
        }
    }
}
