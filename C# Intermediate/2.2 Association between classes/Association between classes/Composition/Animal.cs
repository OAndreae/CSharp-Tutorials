using System;

namespace Composition
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Animal {0} ate", Name);
        }

        public void Sleep()
        {
            Console.WriteLine("Animal {0} slept", Name);
        }
    }
}
