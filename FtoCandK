using System;

namespace FtoCandK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Convert ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Fahrenheit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Celsius");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" and ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Kelvin");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!");

            double number_f;


            while (true)
            {
                Console.Write(": ");
                string input = Console.ReadLine();

                input = input.Replace('.', ',');


                if (double.TryParse(input, out number_f))
                {
                    if (number_f < -459.67)
                    {
                        Console.WriteLine("Please enter a number above or equal to -459,67°F. The number you chose is below absolute zero.");
                    }

                    else
                    {
                        break;
                    }
                }
                
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            }

            double number_c = (number_f - 32) * (5 / 9D);
            number_c = Math.Round(number_c, 2);
            double number_k = number_c + 273.15;
            number_k = Math.Round(number_k, 2);

            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{number_f}°F");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" = ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("~");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{number_c}°C");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" = ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("~");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{number_k}K");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------");
            Console.ResetColor();
            Console.ReadKey(intercept: true);
        }
    }
}
