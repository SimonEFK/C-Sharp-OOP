using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => radius;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("radius cannot be zero or negative");
                }
                radius = value;
            }
        }

        public override double CalculateArea() => Math.PI * this.Radius * this.Radius;
       
        public override double CalculatePerimeter() =>2 * Math.PI * this.Radius;
        public override string Draw()
         =>base.Draw()+ $" {nameof(Circle)}";
        

    }
}
