using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Ellipse(),
                new Triangle()
            };

            shapes.Add(new Rectangle());

            var canvas = new Canvas(shapes);
            canvas.DrawShapes();
        }
    }
}
