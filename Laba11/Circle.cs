using System;
using System.Drawing;

namespace Laba10
{
    class Circle : Point
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Square()
        {
            return Math.PI * radius * radius;
        }
    }
}

