using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Day : ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Input the Month : ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Input the Year : ");
            int year = int.Parse(Console.ReadLine());

            DateTime dateTime = new DateTime(year, month, day);

            Console.WriteLine(dateTime.DayOfWeek);

            Console.WriteLine("The formatted date is : {0}.", dateTime.ToString("dd.MM.yyyy"));

            if (dateTime.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(6).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(5).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(4).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(3).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(2).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(1).ToString("dd.MM.yyyy"));
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("The last day of the week for the above date is : {0}", dateTime.AddDays(0).ToString("dd.MM.yyyy"));
            }
        }
    }
}
