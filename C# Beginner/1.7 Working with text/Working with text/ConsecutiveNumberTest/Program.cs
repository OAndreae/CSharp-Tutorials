using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveNumberTest
{
    /// <summary>
    /// Write a program and ask the user to enter a few numbers separated by a hyphen. 
    /// Work out if the numbers are consecutive.
    /// For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a hyphen separated list of numbers.\n>");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

             Console.WriteLine((isConsecutive(numbers) ? "Consecutive" : "Not Consecutive"));
        }

        static bool isConsecutive(List<int> numbers)
        {
            numbers.Sort();

            for (int i = 1; i < numbers.Count; i++)
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;

            return true;
        }

        //static bool isConsecutive(List<int> numbers)
        //{
        //    var lastNum = numbers.First();
        //
        //    for (int i = 1; i < numbers.Count-1; i++)
        //    {
        //        if (numbers[i] == lastNum + 1 || numbers[i] == lastNum - 1)
        //        {
        //            lastNum = numbers[i];
        //            continue;
        //        }
        //        else
        //            return false;
        //    }

        //    return true;
        //}
    }
}
