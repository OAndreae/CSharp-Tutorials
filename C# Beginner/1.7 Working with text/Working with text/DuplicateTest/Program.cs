using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateTest
{
    /// <summary>
    /// Write a program and ask the user to enter a few numbers separated by a hyphen. 
    /// If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. 
    /// If so, display "Duplicate" on the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a hyphen-separated list of numbers.\n>");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            var numbers = ParseHyphenatedList(input);

            if (ContatinsDuplicates(numbers))
                Console.WriteLine("Duplicate");
        }

       public static List<int> ParseHyphenatedList(string input)
        {
            var numberChars = input.Split('-');

            var numbers = new List<int>();
            for (int i = 0; i < numberChars.Length; i++)
                if (int.TryParse(numberChars[i], out int num))
                    numbers.Add(num);

            return numbers;
        }
       public static bool ContatinsDuplicates(List<int> numbers)
        {
            var uniqueNumbers = new List<int>();
            foreach (var number in numbers)
            {
                // ignore invalid input
                if (uniqueNumbers.Contains(number))
                    return true;

                uniqueNumbers.Add(number);
            }

            return false;
        }
    }
}
