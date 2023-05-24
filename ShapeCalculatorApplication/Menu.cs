using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatorApplication
{
    internal class Menu
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Shape Calculator!");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Please select a shape:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Circle circle = CreateCircle();
                        circle.PrintDetails();
                        break;
                    case "2":
                        Rectangle rectangle = CreateRectangle();
                        rectangle.PrintDetails();
                        break;
                    case "3":
                        Triangle triangle = CreateTriangle();
                        triangle.PrintDetails();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        private static Circle CreateCircle()
        {
            Console.WriteLine("Please enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);
            circle.Name = "Circle";

            return circle;
        }

        private static Rectangle CreateRectangle()
        {
            Console.WriteLine("Please enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of the rectangle:");
            double height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);
            rectangle.Name = "Rectangle";

            return rectangle;
        }

        private static Triangle CreateTriangle()
        {
            Console.WriteLine("Please enter the length of side A:");
            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length of side B:");
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length of side C:");
            double sideC = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            triangle.Name = "Triangle";

            return triangle;
        }
    }
}
