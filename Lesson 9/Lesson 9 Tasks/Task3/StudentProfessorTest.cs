using System;

namespace Task3
{
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person person = new();
            person.Greet();

            Console.WriteLine("----------");

            Student student = new();
            student.Greet();
            student.SetAge(19);
            student.ShowAge();
            student.Study();

            Console.WriteLine("----------");

            Professor professor = new();
            professor.Greet();
            professor.SetAge(28);
            professor.Explain();
        }
    }
}
