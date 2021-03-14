using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class WalkableComponent
    {
        void Walk()
        {
            Console.WriteLine("Walk");
        }
    }

    public class SwimmableComponent
    {
        void Swim()
        {
            Console.WriteLine("Swim");
        }
    }

    public class Fish
    {
        private Animal _animal;
        private SwimmableComponent _swimmableComponent;

        public Fish()
        {
            _animal = new Animal();
            _swimmableComponent = new SwimmableComponent();
            Console.WriteLine("Fish");
        }
    }

    public

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
