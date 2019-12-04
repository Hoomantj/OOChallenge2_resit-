using System;
namespace Shapes_Challenge2
{
    public class Rectangle : Quadrilateral
    {
         

        public Rectangle(string colour, double s1, double s2) : base(colour, s1, s2, s1, s2)
        {

        }

        public override double GetArea()
        {
            return SideLenght1 * SideLenght2;
        }

        public override double GetPerimeter()
        {
            return 2 * (SideLenght1 + SideLenght2);
        }

        public override void Operation1()
        {

        }
    }

}
