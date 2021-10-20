using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please, enter your date of birth : ");
                DateTime birthday = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("The day of week of your birthday is {0}.", birthday.DayOfWeek);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
