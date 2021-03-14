using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            Shape shape = circle;

            if(circle is Circle)
            {
                Circle secondCircle = (Circle)shape;

                // work with secondCircle
            }

            Circle anotherCircle = shape as Circle;
            if(anotherCircle != null)
            {
                // work with anotherCircle
            }

            
        }
    }
}
