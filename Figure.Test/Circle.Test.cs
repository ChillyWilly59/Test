using Figure;

namespace FigureArea.Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateCircle_ValidCircle()
        {
            double radius = 3;

            Assert.DoesNotThrow(() => new Circle(radius));
        }

        [Test]
        public void TestCreateCircle_NotValidCircle()
        {
            double radius = -3;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Test]
        public void TestCalculateArea_ValidCircle()
        {
            double radius = 3;
            double expected = 28.274;
            Circle circle = new(radius);

            double actual = circle.CalculateArea();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}