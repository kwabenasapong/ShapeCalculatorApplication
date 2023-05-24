using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatorApplication
{
    internal class Rectangle : Shape
    {

        private double width;

        private double height;

        public double Width
        {
            get { return width; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException ("Width cannot be negative");
                }

                width = value; 
            }
        }

        public double Height
        {
            get { return height; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException ("Height cannot be negative");
                }

                height = value; 
            }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
