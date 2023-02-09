using System;

namespace AreaCalculation
{
    public class Triangle : Figure
    {

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA = 0, double sideB = 0, double sideC = 0)
        {
            if (!IsCorrectSides(sideA, sideB, sideC))
                throw new ArgumentOutOfRangeException("Wrong paramateres");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

        }

        public bool IsRectangular()
        {
            double max = Math.Max(Math.Max(SideA, SideB), SideC);

            var catSum = new[] { SideA, SideB, SideC }.Sum(i => i == max ? 0 : i * i);

            return max * max == catSum;
        }

        override public double CalculateArea()
        {
            double halfPerimetr = GetHalfPerimetr();

            return Math.Sqrt(halfPerimetr * (halfPerimetr - SideA) * (halfPerimetr - SideB) * (halfPerimetr - SideC));
        }

        double GetHalfPerimetr()
        {
            return (SideA + SideB + SideC) / 2;
        }

        static bool IsCorrectSides(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a || a <= 0 || b <= 0 || c <= 0)
                return false;
            return true;
        }
    }
}

