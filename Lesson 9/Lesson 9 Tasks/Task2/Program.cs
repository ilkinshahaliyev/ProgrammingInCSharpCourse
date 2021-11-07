using System;

namespace Task2
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
                persons[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }
}
