using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Oliver";
            var lastName = "Andreae";
            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var salutation = string.Format("Dear Mr {0}", lastName);
            Console.WriteLine(salutation);

            var friends = new string[3] { "Albert", "William", "Victoria" };
            var friendsList = string.Join(",", friends);
            Console.WriteLine(friendsList);

            var customerMessage = @"You recently enquired how to access the OneDrive folder in your desktop. 
There are three things you need to do:
1) Open File Explorer
2) Click in the bar at the top
3) Type in C:\Users\<YOUR_NAME>\OneDrive\";
            Console.WriteLine(customerMessage);
        }
    }
}
