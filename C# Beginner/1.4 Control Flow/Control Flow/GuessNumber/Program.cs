using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    /// <summary>
    /// Write a program that picks a random number between 1 and 10. 
    /// Give the user 4 chances to guess the number.
    /// If the user guesses the number, display “You won"; otherwise, display “You lost". 
    /// (To make sure the program is behaving correctly, you can display the secret number on the console first.)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 10;
            var secretNumber = new Random().Next(min, max);

            Console.WriteLine("Please guess an integer number in the range [{0}:{1}]", min, max);

            const int maxGuesses = 4;
            for (int i = 0; i < maxGuesses; i++)
            {
                var guess = 0;
                while (!int.TryParse(Console.ReadLine(), out guess))
                    Console.WriteLine("Invalid input. Please try again.");

                if (guess == secretNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }

            Console.WriteLine("You lost");
        }
    }
}
