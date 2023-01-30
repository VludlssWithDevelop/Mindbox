using ShapeLib.Core.Shapes;
using ShapeLib.Core.Shapes.Common;

namespace ShapeLib.Tests
{
    /// <summary>
    /// Тесты методов фигур
    /// </summary>
    public class ShapeTests
    {
        [Theory]
        [InlineData(5, 78.5)]
        public void LowLevelCircleShapeGetArea_ShouldEqual(double radius, double expectedResult)
        {
            // Arrange
            var circleArea = new CircleShape(radius).GetArea();
            var circleAreaRounded = Math.Round(circleArea, 1);

            // Assert
            Assert.Equal(expectedResult, circleAreaRounded);
        }

        [Theory]
        [InlineData(5, 78.5)]
        public void HighLevelCircleShapeGetArea_ShouldEqual(double radius, double expectedResult)
        {
            // Arrange
            var circleArea = Shape.Circle.GetArea(radius);
            var circleAreaRounded = Math.Round(circleArea, 1);

            // Assert
            Assert.Equal(expectedResult, circleAreaRounded);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        public void LowLevelTriangleShapeGetArea_ShouldEqual(double a, double b, double c, double expectedResult)
        {
            // Arrange
            var triangleArea = new TriangleShape(a, b, c).GetArea();
            var triangleAreaRounded = Math.Round(triangleArea, 1);

            // Assert
            Assert.Equal(expectedResult, triangleAreaRounded);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        public void HighLevelTriangleShapeGetArea_ShouldEqual(double a, double b, double c, double expectedResult)
        {
            // Arrange
            var triangleArea = Shape.Triangle.GetArea(a, b, c);
            var triangleAreaRounded = Math.Round(triangleArea, 1);

            // Assert
            Assert.Equal(expectedResult, triangleAreaRounded);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        public void LowLevelTriangleShapeIsRight_ShouldEqual_True(double a, double b, double c, bool expectedResult)
        {
            // Arrange
            var triangleIsRight = new TriangleShape(a, b, c).IsRight;

            // Assert
            Assert.Equal(expectedResult, triangleIsRight);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        public void HighLevelTriangleShapeIsRight_ShouldEqual_True(double a, double b, double c, bool expectedResult)
        {
            // Arrange
            var triangleIsRight = Shape.Triangle.IsRight(a, b, c);

            // Assert
            Assert.Equal(expectedResult, triangleIsRight);
        }
    }
}