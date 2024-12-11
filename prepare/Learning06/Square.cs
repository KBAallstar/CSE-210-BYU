using System;
using System.Dynamic;

namespace Learning06
{
    public class Square : Shape
    {
        private double _side;

        public Square(string color, double side) : base(color)
        {
            _side = side;
        }

        public override double GetArea()
        {
            return _side * _side;
        }
    }
}