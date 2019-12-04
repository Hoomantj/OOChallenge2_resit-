using NUnit.Framework;
using Shapes_Challenge2;

namespace RightAngle_Test
{
    public class Tests
    {
        RightAngle ri;
        private readonly string colour;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5,10,25)]
        [TestCase(4,6,12)]
        [TestCase(9,7,31.5)]
        public void GetAreaTest(double input1, double input2 , double expected)
        {
            ri = new RightAngle(colour, input1, input2 );
            Assert.AreEqual(expected, ri.GetArea());
        }
    }
}