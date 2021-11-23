using System;
using System.IO;
using System.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = File.ReadLines(@"C:\Users\ilkin\Documents\FileInformation.txt").Last();
            Console.WriteLine(line);
        }
    }
}
