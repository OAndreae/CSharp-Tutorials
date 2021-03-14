using System;

namespace TimeValidation
{
    /// <summary>
    /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
    /// A valid time should be between 00:00 and 23:59. 
    /// If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
    /// If the user doesn't provide any values, consider it as invalid time. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a time in the 24-hour format (00:00 to 23:59).\n>");
            var input = Console.ReadLine();
            var message = TimeSpan.TryParse(input, out _) ? "Ok" : "Invalid time";
            Console.WriteLine(message);
        }
    }
}
