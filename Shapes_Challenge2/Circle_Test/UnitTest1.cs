using NUnit.Framework;
using Shapes_Challenge2;

namespace Circle_Test
{
    public class Tests
    {
        Circle cr;
        private readonly string colour;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5,78.55)]
        [TestCase(15,706.95)]
        [TestCase(7,153.96)]
        public void GetAreaTest(double input, double expected)
        {
            cr = new Circle(colour, input);
            Assert.AreEqual((decimal)expected, (decimal)cr.GetArea());
        }
    }
}