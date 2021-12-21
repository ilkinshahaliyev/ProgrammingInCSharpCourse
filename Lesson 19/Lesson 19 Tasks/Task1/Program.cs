using System;
using System.Threading;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread process1Runner = new Thread(() => Process1(200));
            process1Runner.Start();

            Thread process2Runner = new Thread(() => Process2(200));
            process2Runner.Start();

            Console.ReadKey();
        }

        static void Process1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Process 1 - {i}");

                Thread.Sleep(10);
            }
        }

        static void Process2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Process 2 - {i}");

                Thread.Sleep(10);
            }
        }
    }
}
