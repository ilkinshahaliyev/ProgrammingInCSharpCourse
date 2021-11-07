using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any count : ");
            int count = int.Parse(Console.ReadLine());

            Person[] persons = new Person[count];

            for (int i = 0; i < count; i++)
            {
                if (i != 0)
                {
                    persons[i] = new Student(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
            }

            Console.WriteLine("----------");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.WriteLine("----------");

            for (int i = 0; i < count; i++)
            {
                if (i != 0)
                {
                    ((Student)persons[i]).Study();
                }
                else
                {
                    ((Teacher)persons[i]).Explain();
                }
            }
        }
    }
}
