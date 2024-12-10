using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string? word;
            string hiddenWord = "";
            string? guess = "";
            bool guessed = false;
            int mistakes = 0;
            string? previousGuess = "";

            do
            {
                Console.Clear();
                Console.Write("Enter word for hangman: ");
                word = Console.ReadLine();
            } while (string.IsNullOrEmpty(word));
            Console.Clear();

            foreach (char c in word)
            {
                if (c == ' ')
                {
                    hiddenWord += ' ';
                }
                else
                {
                    hiddenWord += '_';
                }
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
                    Console.WriteLine("Please enter something.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                else if (guess.Length > 1)
                {
                    Console.WriteLine("Please only enter one letter at a time.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                else if (word.Contains(guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess[0])
                        {
                            hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guess);
                        }
                    }
                }

                else if (!word.Contains(guess) && guess != previousGuess)
                {
                    Console.WriteLine($"This word doesn't contain '{guess}'.");
                    mistakes++;
                }

                else if (guess == previousGuess)
                {
                    Console.WriteLine($"You've already guessed '{guess}'.");
                }

                previousGuess = guess;

                if (hiddenWord == word)
                {
                    guessed = true;
                    break;
                }
            }

            if (guessed)
            {
                Console.Clear();
                Console.WriteLine($"Number of mistakes: {mistakes}.");
                Console.WriteLine($"Guessed word: \"{word}\".");
                Console.WriteLine("You won!");
                Console.ReadKey(intercept: true);
            }
        }
    }
}
// A little broken will fix later
