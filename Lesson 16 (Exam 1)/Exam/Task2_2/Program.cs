using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\Users\ilkin\Documents\Exam1Task2Info\StudentInfo.txt";

            List<string> list = new List<string>();

            string[] lines = File.ReadAllLines(path);

            while (true)
            {
                string lastLine = File.ReadLines(path).Last();

                foreach (string line in lines)
                {
                    list.Add(line);
                }

                string last = list[list.Count - 1];

                if (last != lastLine)
                {
                    Console.WriteLine("New student registered !");
                    Console.WriteLine(lastLine);
                }
                else
                {
                    Console.WriteLine("Not new student !");
                }

                Thread.Sleep(5000);
            }
        }
    }
}
