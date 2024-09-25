using NumberGuessGame.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guesser Game!");
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Choose a difficulty level:");
                Console.WriteLine("1. Easy (1-50)");
                Console.WriteLine("2. Medium (1-100)");
                Console.WriteLine("3. Hard (1-200)");

                int maxRange = SelectDifficulty();

                Number number = new Number(maxRange); 
                int tries = 0;
                int userGuess = 0;

                Console.WriteLine($"{playerName}, I have selected a number between 1 and {maxRange}. Can you guess it?");

                while (!number.IsCorrectGuess(userGuess))
                {
                    Console.Write("Enter your guess: ");
                    userGuess = int.Parse(Console.ReadLine());
                    tries++;
                    string result = number.CheckGuess(userGuess);
                    Console.WriteLine(result);
                }

                Console.WriteLine($"Congratulations {playerName}! You've guessed the correct number in {tries} tries.");
                Console.Write("Would you like to play again? (y/n): ");
                string response = Console.ReadLine().ToLower();
                playAgain = response == "y";
            }

            Console.WriteLine("Thanks for playing! Goodbye.");
        }

        static int SelectDifficulty()
        {
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                return 50; // Easy
            }
            if (choice == 2)
            {
                return 100; // Medium
            }
            return 200; // Hard by default
        }
    }
    
}

