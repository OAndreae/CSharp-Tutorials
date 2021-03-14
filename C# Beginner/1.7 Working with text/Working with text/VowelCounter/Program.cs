using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCounter
{
    /// <summary>
    /// Write a program and ask the user to enter an English word. 
    /// Count the number of vowels (a, e, o, u, i) in the word. 
    /// So, if the user enters "inadequate", the program should display 6 on the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an English word.\n>");
            var input = Console.ReadLine();

            var word = input;
            if(input.Contains(" "))
                word = input.Substring(0, input.IndexOf(' '));
            var vowelsCount = VowelCount(word);

            Console.WriteLine(vowelsCount > 1?"{0} has {1} vowels": "{0} has {1} vowel", word, vowelsCount);
        }

        public static int VowelCount(string phrase)
        {


            var vowelsCount = 0;
            foreach (var ch in phrase)
                switch (char.ToUpper(ch))
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        vowelsCount++;
                        break;
                    default:
                        break;
                }

            return vowelsCount;
        }
    }
}
