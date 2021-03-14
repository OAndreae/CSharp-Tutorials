using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedLimiter
{
    /// <summary>
    /// Your job is to write a program for a speed camera.
    /// For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
    /// Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
    /// If the user enters a value less than the speed limit, program should display Ok on the console. 
    /// If the value is above the speed limit, the program should calculate the number of demerit points. 
    /// For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
    /// If the number of demerit points is above 12, the program should display License Suspended.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit:");
            float limit;
            while(!Single.TryParse(Console.ReadLine(), out limit))
                Console.WriteLine("Invalid input. Please try again.\nPlease enter the speed limit:");


            Console.WriteLine("Please enter the speed of the car:");
            float speed;
            while (!Single.TryParse(Console.ReadLine(), out speed))
                Console.WriteLine("Invalid input. Please try again.\nPlease enter the speed of the car:");

            if (speed<limit)
                Console.WriteLine("Ok");
            else
            {
                float difference = speed - limit;
                const int demeritLevel = 5;
                var demeritPoints = Math.Floor(difference / demeritLevel);
                Console.WriteLine(demeritPoints > 12.0 ? "Licence Suspended" : demeritPoints.ToString() + " points incurred");
            }
        }
    }
}
