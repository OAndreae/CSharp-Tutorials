using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDateTime = DateTime.Now;
            Console.Write(currentDateTime.ToString("dd MMMM yyyy"));
        }
    }
}
