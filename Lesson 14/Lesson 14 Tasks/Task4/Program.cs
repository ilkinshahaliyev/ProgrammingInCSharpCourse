using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int number = 1;

                Console.Write("Please enter any number to check if this number is even or odd : ");

                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("The message of exception : {0}", exception.Message);
                }


                if (number < 0)
                {
                    try
                    {
                        throw new Exception("Please enter positive number!");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter positive number.");
                    }

                }

                else if (number == 0)
                {
                    break;
                }

                else if (number % 2 == 0)
                {
                    Console.WriteLine("{0} is a even number.", number);
                }

            } while (true);
        }
    }
}
