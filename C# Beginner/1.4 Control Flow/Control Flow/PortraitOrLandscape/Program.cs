using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortraitOrLandscape
{
    /// <summary>
    ///  Write a program and ask the user to enter the width and height of an image. 
    ///  Then tell if the image is landscape or portrait.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of your image");
            float width = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of your image");
            float height = Int32.Parse(Console.ReadLine());

            Console.WriteLine(width>height?"Landscape":"Portrait");

        }
    }
}
