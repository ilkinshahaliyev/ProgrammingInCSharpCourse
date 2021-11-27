using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0, number2 = 0;

            try
            {
                Console.Write("Please enter first double number (Note - Format is string!) : ");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter second double number (Note - Format is string!) : ");
                number2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException exception)
            {
                Console.WriteLine("The message of exception : {0}", exception.Message);

                throw;
            }

            double result = number1 + number2;

            Console.WriteLine(result);
        }
    }
}
