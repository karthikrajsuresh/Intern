using System;

namespace ShapeAreaExample
{
    abstract class Shape
    {
        public abstract double Area();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Problem25_AbstractShapeClass();
        }
        static void Problem25_AbstractShapeClass()
        {
            Shape circle = new Circle(5.0);
            Shape rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Area of the circle: {circle.Area()}");
            Console.WriteLine($"Area of the rectangle: {rectangle.Area()}");
        }
    }
}
