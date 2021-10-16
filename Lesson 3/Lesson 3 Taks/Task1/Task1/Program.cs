using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter any numbers : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("This is even number.");
            }
            else
            {
                Console.WriteLine("This is odd number.");
            }
        }
    }
}
