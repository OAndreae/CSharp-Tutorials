using System;

namespace Casting
{
    public class Circle : Shape
    {
        private float _radius;

        public float Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Diameter must be > 0");
                _radius = value;
            }
        }

        public float Diameter
        {
            get
            {
                return 2*Radius;
            }
        }
    }
}
