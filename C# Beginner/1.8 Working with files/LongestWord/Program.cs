using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    /// <summary>
    /// Write a program that reads a text file and displays the longest word in the file.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\olive\OneDrive\Documents\Computing\Game & Apps\Arithmetic\Description.txt";
            var text = File.ReadAllLines(path);

            Console.WriteLine("Longest word: " + GetLongestWord(string.Join(" ", text)));
        }

        public static string GetLongestWord(string text)
        {
            string longestWord = "";
            foreach (var word in text.Split(' '))
                if (word.Length > longestWord.Length)
                    longestWord = word;
            return longestWord;
        }
    }
}
