using System;

namespace Task5
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

            DateTime date = new DateTime(year, month, day);

            Console.WriteLine("The formatted Date is : {0}", date.ToString("dd.MM.yyyy"));
            Console.WriteLine("The last day of the year {0} is : 31/12/{1}", year, year);
        }
    }
}
