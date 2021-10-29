using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task4
    {
        static void Main(string[] args)
        {
            ChangePlaceOfNumbers(7, 12);
        }

        static void ChangePlaceOfNumbers(int a, int b)
        {
            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine($"The new value of a is {a}, the new value of b is {b}");
        }
    }
}
