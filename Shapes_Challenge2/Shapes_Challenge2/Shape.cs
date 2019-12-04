using System;

namespace Shapes_Challenge2
{
    public abstract class Shape
    {
        public string Colour { get; set; }
        protected Shape(string colour)
        {
            this.Colour = colour;
        }

        public abstract void Operation1();

    }

}
