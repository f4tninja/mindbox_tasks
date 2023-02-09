using System;
using AreaCalculation;

namespace AreaCalculationTests
{
	public static class Instances
    {

		public static Figure CreateEmptyTriangleWithArgumentException()
		{
			return new Triangle();
		}

        public static Figure CreateTriangleWithArgumentException()
        {
            return new Triangle(3.0, -1, 5.0);
        }

        public static Figure CreateEmptyCircleWithArgumentException()
        {
            return new Circle();
        }

        public static Figure CreateCircleWithArgumentException()
        {
            return new Circle(-5);
        }
    }
}

