using AreaCalculation;
namespace AreaCalculationTests;



public class FigureTests
{
    [Fact]
    public void When_CreateValidTriangleCalculateArea_Expect_CalculatedArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double area = triangle.CalculateArea();
        Assert.Equal(6, area);
    }

    [Fact]
    public void When_CreateTriangleWithoutParameters_Expect_ThrowException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Instances.CreateEmptyTriangleWithArgumentException());
    }

    [Fact]
    public void When_CreateTriangleWithWrongParams_Expect_ThrowException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Instances.CreateTriangleWithArgumentException());
    }

    [Fact]
    public void When_CreateRectangularTriangle_Expect_IsRectangularIsTrue()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRectangular());
    }


    [Fact]
    public void When_CreateCircleWithoutParameters_Expect_ThrowException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Instances.CreateEmptyCircleWithArgumentException());
    }

    [Fact]
    public void When_CreateCircleWithWrongParams_Expect_ThrowException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Instances.CreateCircleWithArgumentException());
    }

    [Fact]
    public void When_CreateValidCircleCalculateArea_Expect_CalculatedArea()
    {
        Circle circle = new Circle(10);
        double area = circle.CalculateArea();
        Assert.Equal(Math.PI * 100, area);
    }
}
