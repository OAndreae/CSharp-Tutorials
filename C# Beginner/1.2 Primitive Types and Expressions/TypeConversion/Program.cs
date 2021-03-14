using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            byte b = 55;
            int i = b; // allowed
            Console.WriteLine(b);

            // explicit conversion using casting
            int i2 = 243;
            byte b2 = (byte)i2; // OK since i2<255
            Console.WriteLine("explicit int to byte:{0}", b2);

            // conversion to non-compatible datatype
            string str = "1234";
            var stringInt = Convert.ToInt32(str);
            var parseInt = int.Parse(str);
            Console.WriteLine(stringInt);

            string intStr = Convert.ToString(i2);
            Console.WriteLine(intStr);

            string falseStr = "false";
            var f = Convert.ToBoolean(falseStr);
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
