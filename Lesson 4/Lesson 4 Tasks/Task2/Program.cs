using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your date of birth : ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());

            DateTime now = DateTime.Now;

            TimeSpan totalDays = now - birthday;

            Console.WriteLine("Your current life days is {0}.", totalDays.TotalDays);
        }
    }
}
