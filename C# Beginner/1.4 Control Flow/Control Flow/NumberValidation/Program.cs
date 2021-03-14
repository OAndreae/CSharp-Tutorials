using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberValidation
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. 
        /// The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. 
        /// Otherwise, display "Invalid". 
        /// (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number in the range 1-10:");

            int input = Int32.Parse(Console.ReadLine());
            if(input>=0 && input<=10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
