using System;
namespace Shapes_Challenge2
{
    public abstract class Triangle : Shape
    {
        public double SideLenght1;
        public double SideLenght2;
        public double SideLenght3;


        protected Triangle(string colour, double sideLenght1, double sideLenght2, double sideLenght3) : base(colour)
        {
            this.SideLenght1 = sideLenght1;
            this.SideLenght2 = sideLenght2;
            this.SideLenght3 = sideLenght3;

        }
    }

}
