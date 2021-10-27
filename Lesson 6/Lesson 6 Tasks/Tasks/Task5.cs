using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task5
    {
        static void Main5(string[] args)
        {
            CheckFibonacciSeries(9);
        }

        static void CheckFibonacciSeries(int length)
        {
            int a = 0, b = 1, c;

            Console.Write("{0} {1}", a, b);

            for (int i = 1; i < length; i++)
            {
                c = a + b;

                Console.Write(" {0}", c);

                a = b;
                b = c;
            }
        }
    }
}
