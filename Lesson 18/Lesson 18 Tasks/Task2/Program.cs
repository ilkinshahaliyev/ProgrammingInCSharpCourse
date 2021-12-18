using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            Console.WriteLine(table[0].Name);
            Console.WriteLine(table[1, "Jill"].Name);
        }
    }
}
