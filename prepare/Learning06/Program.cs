using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Blue", 5.25);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("Green", 3, 5);
        shapes.Add(rectangle);
        Circle circle = new Circle("Yellow", 10);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.getColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine("");
        }
    }
}