using NUnit.Framework;
using Shapes_Challenge2;

namespace Equilateral_Test
{
    
    public class Tests
    {
        Equilateral eq;
        private readonly string colour;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5,10.83)]
        [TestCase(15,97.43)]
        [TestCase(7,21.22)]
        public void GetAreaTest(double input, double expected)
        {
            eq = new Equilateral(colour, input);
            Assert.AreEqual(expected, eq.GetArea());
        }

        [TestCase(5, 15)]
        [TestCase(15, 45)]
        [TestCase(7, 21)]
        public void GetPerimeterTest(double input, double expected)
        {
            eq = new Equilateral(colour, input);
            Assert.AreEqual(expected, eq.GetPerimeter());
        }
    }
}