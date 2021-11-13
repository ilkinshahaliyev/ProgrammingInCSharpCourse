using System;

namespace Task2
{
    internal class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            SchoolPerson schoolPerson = new();
            schoolPerson.Name = "Ilkin";
            schoolPerson.Surname = "Shahaliyev";
            schoolPerson.Greet();

            Console.WriteLine("--------------------");

            Student student = new();
            student.Name = "Ilkin";
            student.Surname = "Shahaliyev";
            student.Age = 19;
            student.Greet();
            student.ShowAge();
            student.GoToClasses();

            Console.WriteLine("--------------------");

            Teacher teacher = new();
            teacher.Name = "Nurlan";
            teacher.Surname = "Valizada";
            teacher.Age = 29 + 1;
            teacher.Greet();
            teacher.ShowAge();
            teacher.Explain();
        }
    }
}
