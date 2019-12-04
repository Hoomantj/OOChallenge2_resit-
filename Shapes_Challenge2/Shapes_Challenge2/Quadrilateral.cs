using System;
namespace Shapes_Challenge2
{
    public abstract class Quadrilateral : Shape, IShapeCalc
    {
        public double SideLenght1;
        public double SideLenght2;
        public double SideLenght3;
        public double SideLenght4;

        protected Quadrilateral(string colour, double sideLenght1, double sideLenght2, double sideLenght3, double sideLenght4) : base(colour)
        {
            this.SideLenght1 = sideLenght1;
            this.SideLenght2 = sideLenght2;
            this.SideLenght3 = sideLenght3;
            this.SideLenght4 = sideLenght4;
        }

        public abstract double GetArea();


        public abstract double GetPerimeter();

    }

}
