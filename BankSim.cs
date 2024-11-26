using System;
using System.Reflection.Metadata.Ecma335;

namespace BankSim
{
    class BankSim
    {
        static decimal MoneyC = 100;
        static decimal MoneyS = 50;

        static void Main(string[] args)
        {
            string[] choices = { "Withdraw", "Deposit", "Exit" };

            while (true)
            {
                Console.WriteLine("Welcome to the ATM!");
                DrawLine(20);
                Console.WriteLine($"You currently have {MoneyC}$ in your checkings account, and {MoneyS}$ in your savings account.");
                DrawLine(20);
                Console.WriteLine("Do you want to:\n");
                for (int i = 0; i < choices.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {choices[i]}");
                }
                Console.Write(": ");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Withdraw();
                        Console.Clear();
                        continue;
                    case 2:
                        Deposit();
                        Console.Clear();
                        continue;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
            }
        }

        static void Withdraw()
        {
            Console.Clear();
            Console.WriteLine("Withdrawing Menu");
            DrawLine(20);
            Console.WriteLine("What account do you want to use?");
            DrawLine(20);
            Console.WriteLine($"1. Checkings ({MoneyC}$): ");
            Console.WriteLine($"2. Savings ({MoneyS}$): ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                Console.Write("How much money do you want to withdraw from your savings account? : ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                amount = Math.Round(amount, 2);
                if (amount > MoneyS)
                {
                    Console.WriteLine($"You are missing {amount - MoneyS}$.");
                    Console.ReadKey();
                }
                else if (amount < 0)
                {
                    Console.WriteLine($"You can't enter a negative amount.");
                    Console.ReadKey();
                }
                else
                {
                    MoneyS -= amount;
                    MoneyC += amount;
                    Console.WriteLine($"Current balance in checkings account: {MoneyC}$.");
                }
            }
            if (userChoice == 2)
            {
                Console.Write("How much money do you want to withdraw from your checkings account? : ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                amount = Math.Round(amount, 2);
                if (amount > MoneyC)
                {
                    Console.WriteLine($"You are missing {amount - MoneyC}$.");
                    Console.ReadKey();
                }
                else if (amount < 0)
                {
                    Console.WriteLine($"You can't enter a negative amount.");
                    Console.ReadKey();
                }
                else
                {
                    MoneyS += amount;
                    MoneyC -= amount;
                    Console.WriteLine($"Current balance in savings account: {MoneyS}$.");
                }
            }

        }

        static void Deposit()
        {
            Console.Clear();
            Console.WriteLine("Depositing Menu");
            DrawLine(20);
            Console.WriteLine("What account do you want to use?");
            DrawLine(20);
            Console.WriteLine($"1. Checkings ({MoneyC}$): ");
            Console.WriteLine($"2. Savings ({MoneyS}$): ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                Console.Write("How much money do you want to deposit from your checkings account? : ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                amount = Math.Round(amount, 2);
                if (amount > MoneyC)
                {
                    Console.WriteLine($"You are missing {amount - MoneyC}$.");
                    Console.ReadKey();
                }
                else if (amount < 0)
                {
                    Console.WriteLine($"You can't enter a negative amount.");
                    Console.ReadKey();
                }
                else
                {
                    MoneyS += amount;
                    MoneyC -= amount;
                    Console.WriteLine($"Current balance in checkings account: {MoneyC}$.");
                }
            }
            if (userChoice == 2)
            {
                Console.Write("How much money do you want to deposit from your savings account? : ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                amount = Math.Round(amount, 2);
                if (amount > MoneyS)
                {
                    Console.WriteLine($"You are missing {amount - MoneyS}$.");
                    Console.ReadKey();
                }
                else if (amount < 0)
                {
                    Console.WriteLine($"You can't enter a negative amount.");
                    Console.ReadKey();
                }
                else
                {
                    MoneyS -= amount;
                    MoneyC += amount;
                    Console.WriteLine($"Current balance in savings account: {MoneyS}$.");
                }
            }
        }


        static void DrawLine(int length)
        {
            Console.WriteLine(new string('-', length));
        }
    }
}
