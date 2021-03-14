using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestThree
{
    /// <summary>
    /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
    /// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
    /// otherwise, display the 3 smallest numbers in the list.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Please enter a list of comma-separated numbers.\n>");
                var input = Console.ReadLine();
                var numbersStr = input.Split(',');

                foreach (var number in numbersStr)
                {
                    if (!int.TryParse(number, out int intNum))
                    {
                        Console.WriteLine("'{0}' is invalid and will be ignored.", number);
                        continue;
                    }
                    numbers.Add(intNum);
                }

                const int MinLength = 5;
                if (numbers.Count < MinLength)
                {
                    Console.WriteLine("Invalid list: list is less than {0} elements. Please try again.", MinLength);
                    continue;
                }

                break;
            }

            numbers.Sort();
            Console.WriteLine("Smallest three numbers:");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(numbers[i]);
        }           
        
    }
}
