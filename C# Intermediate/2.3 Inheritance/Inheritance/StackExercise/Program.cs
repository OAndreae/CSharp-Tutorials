using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Clear();

            stack.Push(1);
            stack.Push("Hello");
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
