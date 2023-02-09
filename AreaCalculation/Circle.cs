using System;
namespace AreaCalculation
{
    public class Circle : Figure
    {

        public double Radius { get; }

        public Circle(double radius = 0)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("The radius should be greater than 0");

           Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

