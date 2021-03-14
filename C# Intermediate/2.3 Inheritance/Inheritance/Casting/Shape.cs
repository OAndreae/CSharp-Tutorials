namespace Casting
{
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public void Draw()
        {
            // Boxing
            object obj = 1; 
           
            // Unboxing
            int i = (int)obj;
        }
    }
}
