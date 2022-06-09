using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {

        double height;
        double width;
        public Rectangle(double height,double width)
        {
            Height = height;
            Width = width;
        }

        public double Height
        {
            get => height;
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Value cannot be zero or negative");
                }
                height = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be zero or negative");
                }

                width = value;
            }
        }

        public override double CalculateArea()
        => (this.Width * this.Height);

        public override double CalculatePerimeter()
        => (2 * this.Width) + (2 * this.Height);

        public override string Draw() => base.Draw()+ $" {nameof(Rectangle)}";
        
    }
}
