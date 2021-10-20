using System;

namespace Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter day : ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter month : ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter year : ");
            int year = int.Parse(Console.ReadLine());

            string check = string.Empty;

            if ((day > 31) && (month > 12))
            {
                check = "False";
            }
            else
            {
                check = "True";
            }

            DateTime dateTime = new DateTime(year, month, day);

            Console.WriteLine("The formatted Date is : {0}. The current date status : {1}", dateTime.ToString("dd.MM.yyyy"), check);
        }
    }
}
