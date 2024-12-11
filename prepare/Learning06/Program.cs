using System;
using Learning06;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Square square = new Square("Red", 5);
        Console.WriteLine($"Area of square: {square.GetArea()}. Color: {square.GetColor()}.");

        Rectangle rectangle = new Rectangle("Blue", 5, 10);
        Console.WriteLine($"Area of rectangle: {rectangle.GetArea()}. Color: {rectangle.GetColor()}.");

        Circle circle = new Circle("Green", 5);
        Console.WriteLine($"Area of circle: {circle.GetArea()}. Color: {circle.GetColor()}.");
    }
}