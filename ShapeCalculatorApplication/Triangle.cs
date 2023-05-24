using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatorApplication
{
    internal class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA
        {
            get { return sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side A cannot be negative");
                }

                sideA = value;
            }
        }

        public double SideB
        {
            get { return sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side B cannot be negative");
                }

                sideB = value;
            }
        }

        public double SideC
        {
            get { return sideC; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side C cannot be negative");
                }

                sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
