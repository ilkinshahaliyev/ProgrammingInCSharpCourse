using System;
using System.IO;

namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\Users\ilkin\Documents\Exam1Task2Info\StudentInfo.txt";
            bool isContinue = true;

            while (isContinue)
            {
                Student student = new Student();
                Console.Write("Enter student id : ");
                student.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter student name : ");
                student.Name = Console.ReadLine();

                Console.Write("Enter student surname : ");
                student.Surname = Console.ReadLine();

                Console.Write("Enter student date of birth : ");
                student.DateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Do you want to continue ? (true / false)");
                isContinue = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();

                var result = student.Print();

                File.AppendAllText(path, result);

                if (isContinue == false)
                {
                    break;
                }
            }
        }
    }
}
