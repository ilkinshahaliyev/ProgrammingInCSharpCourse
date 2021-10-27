using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task6
    {
        static void Main6(string[] args)
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            SumOfTheDigitsOfNumber(number);
        }

        static void SumOfTheDigitsOfNumber(int number)
        {
            int sum = 0;

            do
            {
                sum += (number % 10);
                number /= 10;
            } while (number > 0);

            Console.WriteLine("The sum of the digits of the number is {0}", sum);
        }
    }
}
