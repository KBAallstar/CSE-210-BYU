using System;
using System.Dynamic;

namespace Learning06
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}