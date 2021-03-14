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
            // rectangular array 
            var matrix = new int[2, 3]
            {
                { 1, 5, 5 },
                { 6, 4, 2 },
            };

            Console.WriteLine("\n\tRectangular array (matrix)");
            foreach (var num in matrix)
                Console.WriteLine("\t" + num.ToString());

            // jaged array
            var jagged = new int[3][]
            {
                new int[]{0,1,2,3},
                new int[]{0,1,2,3,4,5,6,7,8,9},
                new int[]{0,1,2,3,4}
            };

            Console.WriteLine("\n\tJagged array");
            foreach (var array in jagged)
                foreach (var num in array)
                    Console.WriteLine("\t" + num.ToString());

            Console.WriteLine();
        }
    }
}
