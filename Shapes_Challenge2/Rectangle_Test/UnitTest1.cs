using NUnit.Framework;
using Shapes_Challenge2;

namespace Rectangle_Test
{
    public class Tests
    {
        Rectangle rec;
        private readonly string colour;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase (5,10,50)]
        [TestCase(4,6,24)]
        [TestCase(9,7,63)]
        public void GetAreaTest(double input1, double input2, double expected)
        {
            rec = new Rectangle(colour,input1,input2 );
            Assert.AreEqual(expected, rec.GetArea());
        }

        [TestCase(5, 10, 30)]
        [TestCase(4, 6, 20)]
        [TestCase(9, 7, 32)]
        public void GetPerimeterTest(double input1, double input2, double expected)
        {
            rec = new Rectangle(colour, input1, input2);
            Assert.AreEqual(expected, rec.GetPerimeter());
        }
    }
}