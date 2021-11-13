using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Circle : Shape
    {
        protected double radius;

        public Circle(double radius = 4)
        {
            this.radius = radius;
        }

        public new double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public new double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
