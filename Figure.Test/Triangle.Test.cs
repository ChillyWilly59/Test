using Figure;

namespace FigureArea.Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateTriangle_ValidTriangle()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new(a, b, c);

            Assert.DoesNotThrow(() => new Triangle(a, b, c));
        }

        [Test]
        public void TestCreateTriangle_NotValidTriangle()
        {
            double a = 3;
            double b = 4;
            double c = 8;

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void TestCalculateArea_ValidTriangle()
        {
            
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            Triangle triangle = new(a, b, c);

            double actual = triangle.CalculateArea();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestIsRightTriangle_True()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Boolean expected = true;
            Triangle triangle = new(a, b, c);

            Boolean actual = triangle.IsRightTriangle();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestIsRightTriangle_False()
        {
            double a = 3;
            double b = 4;
            double c = 6;
            Boolean expected = false;
            Triangle triangle = new(a, b, c);

            Boolean actual = triangle.IsRightTriangle();

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}