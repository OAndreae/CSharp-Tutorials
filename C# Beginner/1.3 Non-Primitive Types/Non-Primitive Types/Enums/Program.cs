using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum Day
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5, 
            Saturday = 6,
            Sunday = 7
        };

        static void Main(string[] args)
        {
            var today = Day.Sunday;
            Console.WriteLine("Today is {0}", today.ToString());
            Console.WriteLine("Today is the {0}th day of the week", (int)today);

            var dayNum = 4;
            Console.WriteLine("{0} is {1}", dayNum, (Day)dayNum);

            var favouriteDayText = "Friday";
            Console.WriteLine("{0} is the same as {1}", favouriteDayText, Enum.Parse(typeof(Day), favouriteDayText));
        }
    }
}
