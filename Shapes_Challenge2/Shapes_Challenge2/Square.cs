using System;
namespace Shapes_Challenge2
{
    public class Square : Quadrilateral
    {
        //public double S1 { get; set; }
        public Square(string colour, double s1) : base(colour, s1, s1, s1, s1)
        {
            
        }

        public override void Operation1()
        {

        }

        public override double GetArea()
        {
             double area = SideLenght1 * SideLenght1;
            return area;
        }

        public override double GetPerimeter()
        {
            return 4 * SideLenght1;
        }

         
    }
}
