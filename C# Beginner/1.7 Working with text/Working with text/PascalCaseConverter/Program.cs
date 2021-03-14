using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCaseConverter
{
    /// <summary>
    /// Write a program and ask the user to enter a few words separated by a space. 
    /// Use the words to create a variable name with PascalCase. 
    /// For example, if the user types: "number of students", display "NumberOfStudents".
    /// Make sure that the program is not dependent on the input.
    /// So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while(string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Please enter a few words.\n>");
                input = Console.ReadLine();
            }

            Console.WriteLine(ToPascalCase(input));

            //var words = input.Split(' ');
            //for (int i = 0; i < words.Length; i++)
            //{
            //    var word = words[i].ToLower();
            //    var firstLetter = words[i].First().ToString().ToUpper();
            //    word = word.Remove(0,1);
            //    words[i] = firstLetter + word;
            //}
            //
            //Console.WriteLine(string.Join("", words));
        }

        public static string ToPascalCase(string words)
        {
            var variableName = "";
            foreach (var word in words.Split(' '))
            {
                var firstLetter = char.ToUpper(word[0]);
                variableName += firstLetter + word.Substring(1);
            }

            return variableName;
        }
    }
}
