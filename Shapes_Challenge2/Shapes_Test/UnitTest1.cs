using NUnit.Framework;
using Shapes_Challenge2;

namespace Square_Test
{
    public class Tests
    {
        Square sq;
         
        private readonly string colour;
         

        [SetUp]
        
        public void Setup()
        {
            
        }

        [TestCase(5,25)]
        [TestCase(15,225)]
        [TestCase(7,49)]
        public void GetAreaTest(double input , double expected)
        {
            sq = new Square(colour, input);
            Assert.AreEqual(expected, sq.GetArea());
        }
        [TestCase(5,20)]
        [TestCase(15,60)]
        [TestCase(7,28)]
        public void GetPerimeterTest(double input, double expected)
        {
            sq = new Square(colour, input);
            Assert.AreEqual(expected, sq.GetPerimeter());
        }

    }
}