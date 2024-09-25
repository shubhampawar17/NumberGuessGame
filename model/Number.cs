using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame.model
{
    internal class Number
    {
        private int numberToGuess;

        public Number(int maxRange)
        {
            Random random = new Random();
            numberToGuess = random.Next(1, maxRange + 1); // Generate number based on the selected range
        }

        public string CheckGuess(int guess)
        {
            if (guess < numberToGuess)
            {
                return "Sorry, Too Low.";
            }
            if (guess > numberToGuess)
            {
                return "Sorry, Too High.";
            }
            return "Correct!";
        }

        public bool IsCorrectGuess(int guess)
        {
            return guess == numberToGuess;
        }
    }
}
