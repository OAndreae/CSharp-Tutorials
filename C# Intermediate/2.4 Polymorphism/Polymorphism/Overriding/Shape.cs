using System;

namespace Overriding
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }

    public class Ellipse : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    public class Triangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }
    }
}
