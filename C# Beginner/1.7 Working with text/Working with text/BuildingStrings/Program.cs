using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(56.456f.ToString("C"));

            var builder = new StringBuilder("Dear Mr M.I.Nister");
                builder
                .AppendLine()
                .Append("This message has been constructed using a string builder.")
                .AppendLine()
                .Append("If you would like to use it, I will only charge you ").Append(45.55f.ToString("C2"))
                .AppendLine()
                .Append('-', 15)
                .AppendLine()
                .Append("Best wishes\nOliver");
            Console.WriteLine(builder);
        }
    }
}
