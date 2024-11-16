using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("First to three!");
            Console.WriteLine("Rock, paper, or scissors?");
            Console.ResetColor();

            bool won = false;

            int playerWins = 0;
            int computerWins = 0;

            string[] choices = { "rock", "paper", "scissors" };

            Random random = new Random();

            while (!won)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": ");
                Console.ResetColor();
                string? players_choice = Console.ReadLine();
                players_choice = players_choice?.ToLower();

                if (string.IsNullOrEmpty(players_choice) || !Array.Exists(choices, choice => choice == players_choice))
                {
                    Console.WriteLine("Choose rock, paper, or scissors.");
                    continue;
                }

                string computers_choice = choices[random.Next(choices.Length)];


                if (players_choice == computers_choice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a tie!");
                    Console.ResetColor();
                }
                else if ((players_choice == "rock" && computers_choice == "scissors") ||
                         (players_choice == "paper" && computers_choice == "rock") ||
                         (players_choice == "scissors" && computers_choice == "paper"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won!");
                    Console.ResetColor();
                    playerWins++;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost!");
                    Console.ResetColor();
                    computerWins++;
                }

                DisplayChoices(players_choice, computers_choice);

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Player: {playerWins}, Computer: {computerWins}.");
                Console.ResetColor();

                if (playerWins == 3 || computerWins == 3)
                {
                    won = true;
                }

            }

            if (playerWins == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Good job! You won!");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Good try! You lost!");
                Console.ResetColor();
            }
        }

        static void DisplayChoices(string p_choice, string c_choice)
        {
            Console.WriteLine($"Players choice: {p_choice}.");
            Console.WriteLine($"Computers choice: {c_choice}.");
        }

    }
}