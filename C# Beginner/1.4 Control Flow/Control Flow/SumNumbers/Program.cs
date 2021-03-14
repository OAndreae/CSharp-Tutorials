using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    /// <summary>
    /// Write a program and continuously ask the user to enter a number or "ok" to exit. 
    /// Calculate the sum of all the previously entered numbers and display it on the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const string exitCommand = "OK";

            Console.WriteLine("Please enter some numbers. After each entry, press 'enter'.\n" +
                "Press enter " + exitCommand + " to find the sum.");

            double sum = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToUpper() == "OK")
                    break;

                var num = 0;
                if (!Int32.TryParse(input, out num))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                sum += num;                        
            }

            Console.WriteLine(sum);
        }
    }
}
