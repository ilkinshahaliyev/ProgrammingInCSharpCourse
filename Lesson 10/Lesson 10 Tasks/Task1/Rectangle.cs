using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangle : Shape
    {
        protected double side1, side2;

        public Rectangle(double side1 = 3, double side2 = 5)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public new double Perimeter()
        {
            return 2 * (side1 + side2);
        }

        public new double Area()
        {
            return side1 * side2;
        }
    }
}
