using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    /// <summary>
    /// Write a program and ask the user to enter a number.
    /// Compute the factorial of the number and print it on the console.
    /// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            var input = 0;
            while(!int.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Invalid input. Please try again.");

            var factorialSum = input!=0?1:0;
            for (int i = input; i > 0; i--)
                factorialSum *= i;

            Console.WriteLine("{0}! = {1}", input, factorialSum);
        }
    }
}
