using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNum
{
    /// <summary>
    ///  Write a program which takes two numbers from the console and displays the maximum of the two.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number:");
            float num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number:");
            float num2 = Int32.Parse(Console.ReadLine());

            Console.Write(num1 > num2 ? num1 : num2);
        }
    }
}
