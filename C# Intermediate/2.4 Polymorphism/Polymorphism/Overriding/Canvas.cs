using System.Collections.Generic;

namespace Overriding
{
    public class Canvas
    {
        private readonly List<Shape> _shapes = new List<Shape>();

        public Canvas()
        {
        }

        public Canvas(List<Shape> shapes)
        {
            _shapes = shapes;
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void DrawShapes()
        {
            foreach (var shape in _shapes)
            {
                shape.Draw();
            }
        }
    }
}
