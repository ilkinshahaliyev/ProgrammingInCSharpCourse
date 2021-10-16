using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any letters : ");
            char[] letters = Console.ReadLine().ToCharArray();

            Array.Reverse(letters);
            Console.WriteLine(new string(letters));
        }
    }
}
