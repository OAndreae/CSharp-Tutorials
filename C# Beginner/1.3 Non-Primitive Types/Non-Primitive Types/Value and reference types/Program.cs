using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_reference_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 44;
            var b = a;
            Console.WriteLine("Value Types\na: {0}, b: {1}", a, b);

            var person = new Person()
            {
                FirstName = "Oliver",
                LastName = "Andreae"
            };

            var person2 = person;
            person2.FirstName = "Elliot";
            Console.WriteLine("person.FirstName: {0}, person2.FirstName: {1}", person.FirstName, person2.FirstName);
        }
    }
}
