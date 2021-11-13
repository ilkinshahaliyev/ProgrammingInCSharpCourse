using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1; 

            Rectangle[] rectangles = new Rectangle[number];

            int i;

            for (i = 0; i < number; i++)
            {
                rectangles[i] = new Rectangle(4, 8);
            }

            foreach (var item in rectangles)
            {
                Console.WriteLine(item.Perimeter());
                Console.WriteLine(item.Area());
            }

            Console.WriteLine("-----");

            Circle[] circles = new Circle[number];

            int j;

            for (j = 0; j < number; j++)
            {
                circles[j] = new Circle(6);
            }

            foreach (var item in circles)
            {
                Console.WriteLine(item.Perimeter());
                Console.WriteLine(item.Area());
            }
        }
    }
}
