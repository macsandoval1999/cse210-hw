using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle("Red", 5, 10),
            new Circle("Blue", 3),
            new Square("Green", 4),   
        };
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}