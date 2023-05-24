using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatorApplication
{
    internal abstract class Shape
    {
        private string name;

        public string Name 
        {
            get { return name; }
            set { name = value; }   
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public void PrintDetails()
        {
            Console.WriteLine($"Shape: {Name}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }
}
