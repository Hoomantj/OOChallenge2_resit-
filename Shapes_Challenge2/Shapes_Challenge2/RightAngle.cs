using System;
namespace Shapes_Challenge2
{
    public class RightAngle : Triangle, IShapeCalc
    {
         
        
        
        public RightAngle(string colour, double s1, double s2) : base(colour, s1, s2,(Math.Sqrt(s1 * s1 + s2 * s2)))
        {
            
        }

        public override void Operation1()
        {
        }

        public double GetArea()
        {
            double area = SideLenght1 * SideLenght2 / 2;
            return Math.Round(area, 2);
        }

        public double GetPerimeter()
        {
            
            double perimetere= SideLenght1 + SideLenght2 + Math.Sqrt(SideLenght1 * SideLenght1 + SideLenght2 * SideLenght2);
            return Math.Round(perimetere, 2);
        }
    }
}
