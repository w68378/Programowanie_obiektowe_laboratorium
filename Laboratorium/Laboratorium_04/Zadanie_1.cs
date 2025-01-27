using System;
using System.Collections.Generic;

abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Rysowanie figury...");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Rysowanie prostokąta.");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Rysowanie trójkąta.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Rysowanie koła.");
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle(),
            new Triangle(),
            new Circle()
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
