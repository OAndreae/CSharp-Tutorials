using System;

namespace Constructors
{
    public class Foodstuff
    {
        private string _name;

        public Foodstuff(string name)
        {
            _name = name;
            Console.WriteLine("Foodstuff called '{0}' initialised.", name);
        }
    }
}
