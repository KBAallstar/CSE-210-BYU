using System;
using System.Dynamic;

namespace Learning06
{
    public abstract class Shape
    {
        private string _color;

        public abstract double GetArea();

        public Shape(string color) // Constructor
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }
    }
}