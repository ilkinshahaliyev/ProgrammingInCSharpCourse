using System;

namespace Task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the perimeter of circle : ");
            double radius = double.Parse(Console.ReadLine());

            double perimeterOfCircle = 2 * Math.PI * radius;
            double areaOfCircle = Math.PI * radius * radius;

            Console.WriteLine("The perimeter of circle is {0}", perimeterOfCircle);
            Console.WriteLine("The area of circle is {0}", areaOfCircle);
        }
    }
}
