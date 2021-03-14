using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingWords
{
    class Program
    {
        /// <summary>
        ///  Write a program that reads a text file and displays the number of words.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var path = @"C:\Users\olive\OneDrive\Documents\Computing\Game & Apps\Arithmetic\Description.txt";
            var text = File.ReadAllText(path);
            Console.WriteLine("File has {0} words", text.Split(' ').Length); 
        }
    }
}
