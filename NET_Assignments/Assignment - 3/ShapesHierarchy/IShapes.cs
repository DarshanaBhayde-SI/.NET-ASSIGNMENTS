using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShapesHierarchy
{
    public interface IShapes
    {
        double CalculateArea();
        double CalculatePerimeter();
        void DisplayShapeDetails();
    }

    class Circle : IShapes
    {
        double radius;
        double pi;

        public Circle(double radius, double pi)
        {
            this.radius = radius;
            this.pi = pi;
        }

        public double CalculateArea()
        {
            return pi * radius * radius;

        }

        public double CalculatePerimeter()
        {
            return 2 * pi * radius;
        }

        public void DisplayShapeDetails()
        {
            Console.WriteLine($"Area of Rectangle with radius {radius} is: {CalculateArea()} ");
            Console.WriteLine($"Perimeter of Rectangle with radius {radius} is: {CalculatePerimeter()} ");
        }
    }

    class Rectangle : IShapes
    {
        double length;
        double breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public double CalculateArea()
        {
            return length * breadth;

        }

        public double CalculatePerimeter()
        {
            return 2 * (length + breadth);
        }

        public void DisplayShapeDetails()
        {
            Console.WriteLine($"Area of Rectangle with length {length} and breadth {breadth} is: {CalculateArea()} ");
            Console.WriteLine($"Perimeter of Rectangle with length {length} and breadth {breadth} is: {CalculatePerimeter()} ");
        }
    }
    class Triangle : IShapes
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            return (1 / 2) * side1 * side2;

        }

        public double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }

        public void DisplayShapeDetails()
        {
            Console.WriteLine($"Area of Triangle with base {side2} and height {side1} is: {CalculateArea()} ");
            Console.WriteLine($"Perimeter of Triangle with sides - {side1}, {side2}, {side3} is: {CalculatePerimeter()} ");
        }
    }
}
