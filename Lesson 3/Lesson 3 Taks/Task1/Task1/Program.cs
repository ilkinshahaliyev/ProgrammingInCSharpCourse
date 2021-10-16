using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter any numbers : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please, enter any numbers : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if ((number1 % 2 == 0) && (number2 % 2 == 0))
            {
                Console.WriteLine("True");
            }
            else if ((number1 % 2 == 1) && (number2 % 2 == 1))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
