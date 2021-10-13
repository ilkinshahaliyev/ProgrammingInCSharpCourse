using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name and surname : ");
            string information = Console.ReadLine();

            Console.WriteLine("Your name and surname uppercase form is : {0}", information.ToUpper());
        }
    }
}
