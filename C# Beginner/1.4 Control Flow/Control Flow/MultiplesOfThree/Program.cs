using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOfThree
{
    /// <summary>
    /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
    /// Display the count on the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            for (int i = 1; i < max; i++)
                if(i%3==0)
                    Console.WriteLine(i);
        }
    }
}
