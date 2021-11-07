using System;

namespace Task5
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }

        public void Explain()
        {
            Console.WriteLine("I am explaining.");
        }
    }
}
