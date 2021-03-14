using System;

namespace AbstractClasses
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Position { get; set; }

        public abstract void Draw();
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
