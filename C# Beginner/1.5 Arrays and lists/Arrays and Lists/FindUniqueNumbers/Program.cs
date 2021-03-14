using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUniqueNumbers
{
    /// <summary>
    ///  Write a program and ask the user to continuously enter a number or type "Quit" to exit.
    ///  The list of numbers may include duplicates.
    ///  Display the unique numbers that the user has entered.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Please enter a number (or type 'Quit' to exit).\n>");
                var input = Console.ReadLine();

                if (input.ToUpper() == "QUIT")
                    break;

                if (!int.TryParse(input, out int num))
                {
                    Console.WriteLine("'{0}' is not an integer. Please try again.", input);
                    continue;
                }

                if (!numbers.Contains(num))
                    numbers.Add(num);
            }

            Console.WriteLine("Unique numbers entered:");
            foreach (var number in numbers)
                Console.WriteLine(number);            
        }
    }
}
