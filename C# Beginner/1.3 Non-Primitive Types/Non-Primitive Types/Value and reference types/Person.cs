using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_reference_types
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }
    }

    public struct Point
    {
        public int x;
        public int y;
    }

}
