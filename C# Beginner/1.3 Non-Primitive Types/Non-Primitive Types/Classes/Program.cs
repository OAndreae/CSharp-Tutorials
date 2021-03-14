using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Classes.Maths;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var oliverAndreae = new Person();
            oliverAndreae.FirstName = "Oliver";
            oliverAndreae.LastName = "Andreae";
            oliverAndreae.Introduce();

            var harrisonCaine = new Person()
            {
                FirstName = "Harrison",
                LastName = "Caine"
            };
            harrisonCaine.Introduce();

            Console.WriteLine(Calculator.Add(2, 3));

            Console.ReadKey();
        }
    }
}
