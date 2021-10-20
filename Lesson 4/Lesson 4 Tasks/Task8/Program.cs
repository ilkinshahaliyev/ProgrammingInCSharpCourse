using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter The day of week (1 - 7) : ");
            int dayOfWeek = int.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine(WeekDay.Monday);
                    break;
                case 2:
                    Console.WriteLine(WeekDay.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(WeekDay.Wednesday);
                    break;
                case 4:
                    Console.WriteLine(WeekDay.Thursday);
                    break;
                case 5:
                    Console.WriteLine(WeekDay.Friday);
                    break;
                case 6:
                    Console.WriteLine(WeekDay.Saturday);
                    break;
                case 7:
                    Console.WriteLine(WeekDay.Sunday);
                    break;
                default:
                    Console.WriteLine("You must enter a number between 1 and 7");
                    break;
            }
        }
    }

    public enum WeekDay
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
}
