using System;
namespace Shapes_Challenge2
{
    public class Equilateral : Triangle, IShapeCalc
    {
         
        public Equilateral(string colour, double s1) : base(colour, s1, s1, s1)
        {
             
        }

        public override void Operation1()
        {

        }

        public double GetArea()
        {
             double area=((Math.Sqrt(3)) / 4) * SideLenght1 * SideLenght1;
             
            return Math.Round(area, 2);
        }

        public double GetPerimeter()
        {
            return 3 * SideLenght1;
        }
    }
}
