using System;
namespace Shapes_Challenge2
{
    public class Circle : Shape, IShapeCalc
    {
        public readonly double PI = Math.Round(Math.PI, 3); 
        public double Radius { get; set; }
        public Circle(string colour, double radius) : base(colour)
        {
            this.Radius = radius;
             
        }

        public double GetArea()
        {
            double area = PI * Radius * Radius;
            return Math.Round(area, 2);
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * PI * Radius;
            return Math.Round(perimeter, 2);
        }

        public override void Operation1()
        {

        }
    }

}
