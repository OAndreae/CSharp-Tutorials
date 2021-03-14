using System;

namespace Constructors
{
    public class Fruit : Foodstuff
    {
        public Fruit(string name)
            :base(name)
        {
            Console.WriteLine("Fruit called '{0}' initialised.", name);
        }
    }
}
