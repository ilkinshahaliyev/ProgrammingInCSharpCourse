using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string input : ");
            string firstInput = Console.ReadLine();

            Console.Write("Enter second string input : ");
            string secondInput = Console.ReadLine();

            if (firstInput.Contains(secondInput))
            {
                Console.WriteLine("{0} is in {1}", secondInput, firstInput);
            }
            else
            {
                Console.WriteLine("{0} is not in {1}", secondInput, firstInput);
            }
        }
    }
}
