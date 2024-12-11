using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main()
        {
            string? word;
            string hiddenWord = "";
            string? guess;
            bool guessed = false;
            int mistakes = 0;
            var previousGuesses = new HashSet<char>();

            do
            {
                Console.Clear();
                Console.Write("Enter word for hangman: ");
                word = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(word));

            Console.Clear();

            foreach (char c in word)
            {
                hiddenWord += (c == ' ') ? ' ' : '_';
            }

            while (!guessed)
            {
                Console.Clear();
                Console.WriteLine($"Number of mistakes: {mistakes}.");
                Console.WriteLine(hiddenWord);
                Console.Write("> ");
                guess = Console.ReadLine();

                if (string.IsNullOrEmpty(guess))
                {
                    Console.Write("Please enter something.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                else if (guess.Length > 1)
                {
                    Console.Write("Please only enter one letter at a time.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                else if (previousGuesses.Contains(guess[0]))
                {
                    Console.Write($"You've already guessed '{guess}'.");
                    Console.ReadKey();
                    continue;
                }

                else
                {
                    previousGuesses.Add(guess[0]);
                }

                if (word.Contains(guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess[0])
                        {
                            hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guess);
                        }
                    }
                }

                else
                {
                    Console.WriteLine($"You've already guessed '{guess}'.");
                    mistakes++;
                }

                if (hiddenWord == word)
                {
                    guessed = true;
                    break;
                }
            }

            if (guessed)
            {
                Console.Clear();
                Console.WriteLine($"Number of mistakes: {mistakes}");
                Console.WriteLine($"Guessed word: \"{word}\".");
                Console.WriteLine("You won!");
                Console.ReadKey(intercept: true);
            }
        }
    }
}