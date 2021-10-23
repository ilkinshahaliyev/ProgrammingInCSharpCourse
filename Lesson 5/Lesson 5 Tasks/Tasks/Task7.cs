using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task7
    {
        static void Main7()
        {
            Console.Write("Input the number or terms : ");
            int numberOfTerms = int.Parse(Console.ReadLine());

            int number = 9;
            int sum = 0;

            for (int i = 0; i < numberOfTerms; i++)
            {
                Console.Write("{0} ", number);

                sum += number;
                number = (number * 10) + 9;
            }

            Console.WriteLine();

            Console.WriteLine("The sum of number series is {0}", sum);
        }
    }
}
