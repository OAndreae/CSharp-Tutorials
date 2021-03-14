using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterUniqueNumbers
{
    /// <summary>
    /// Write a program and ask the user to enter 5 numbers. 
    /// If a number has been previously entered, display an error message and ask the user to re-try. 
    /// Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfInputs = 5;

            Console.WriteLine("Please enter {0} unique integer numbers:", Convert.ToString(NumberOfInputs));
            var numbers = new List<int>();
            while (numbers.Count < NumberOfInputs)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int num) && !numbers.Contains(num))
                {
                    numbers.Add(num);
                    break;
                }

                Console.WriteLine("\'{0}\' is invalid input. Please input is an integer that you haven't already entered.", input);
            }

            numbers.Sort();

            Console.WriteLine();
            foreach (var number in numbers)
                Console.WriteLine(number);

        }
    }
}
