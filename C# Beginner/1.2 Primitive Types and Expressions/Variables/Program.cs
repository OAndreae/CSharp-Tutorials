using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // var may be used instead of indiviual datatypes

            var age = 16;
            var year = 2019;
            var temperature = 31.24f;
            var character = 'A';
            var name = "Oliver";
            var isLearning = true;

            Console.WriteLine("Variables");
            Console.WriteLine(age);
            Console.WriteLine(year);
            Console.WriteLine(temperature);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine(isLearning);

            const float Pi = 3.14f;
            Console.WriteLine("\nConstants");
            Console.WriteLine(Pi);

            Console.WriteLine("\nFormating data");
            Console.WriteLine("Byte range of values {0}-{1}", byte.MinValue, byte.MaxValue );
        }
    }
}
