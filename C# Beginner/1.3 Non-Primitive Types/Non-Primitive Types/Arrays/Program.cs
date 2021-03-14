using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] years = new int[3];
            years[0] = 44;
            years[1] = 35;
            Console.WriteLine(years[0]);
            Console.WriteLine(years[1]);
            Console.WriteLine(years[2]);

            float[] temperatures = new float[4] { 32.4f, 13.2f, 4.32f, 25.7f };
            Console.WriteLine(temperatures[0]);
            Console.WriteLine(temperatures[1]);
            Console.WriteLine(temperatures[2]);
            Console.WriteLine(temperatures[3]);

            Console.ReadLine();
        }
    }
}
