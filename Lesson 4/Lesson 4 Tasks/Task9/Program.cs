using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer : ");
            int firstInteger = int.Parse(Console.ReadLine());

            Console.Write("Enter the first integer : ");
            int secondInteger = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose one of the following options : \n" +
                "1 - Addition." + "\n" +
                "2 - Substraction." + "\n" +
                "3 - Multiplication." + "\n" +
                "4 - Division." + "\n" +
                "5 - Exit.");

            short number = byte.Parse(Console.ReadLine());

            if ((number > 5) && (number < 1))
            {
                Console.WriteLine("You must enter a number between 1 and 5.");
            }

            if (number == (short)Options.Addition)
            {
                Console.WriteLine(firstInteger + secondInteger);
            }
            else if (number == (short)Options.Substraction)
            {
                Console.WriteLine(firstInteger - secondInteger);
            }
            else if (number == (short)Options.Multiplication)
            {
                Console.WriteLine(firstInteger * secondInteger);
            }
            else if (number == (short)Options.Division)
            {
                Console.WriteLine(firstInteger / secondInteger);
            }
            else if (number == (short)Options.Exit)
            {
                Console.WriteLine("Successfully exited the program.");
            }
        }
    }

    public enum Options
    {
        Addition = 1,
        Substraction = 2,
        Multiplication = 3,
        Division = 4,
        Exit = 5
    }
}
