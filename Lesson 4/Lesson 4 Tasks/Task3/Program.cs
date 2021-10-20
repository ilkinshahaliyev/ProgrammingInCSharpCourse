using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime after40Days = now.AddDays(40);

            Console.WriteLine("The day of the week after 40 days from this moment is {0}.", after40Days.DayOfWeek);
        }
    }
}
