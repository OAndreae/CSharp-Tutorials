using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumInSeries
{
    /// <summary>
    /// Write a program and ask the user to enter a series of numbers separated by comma. 
    /// Find the maximum of the numbers and display it on the console. 
    /// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of number separated by a comma:");

            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var maxNum = int.MinValue;
            foreach (var str in numbers)
            {
                if (Convert.ToInt32(str) > maxNum)
                    maxNum = Convert.ToInt32(str);               
            }

            Console.WriteLine("Maximum: {0}", maxNum);           
        }
    }
}
