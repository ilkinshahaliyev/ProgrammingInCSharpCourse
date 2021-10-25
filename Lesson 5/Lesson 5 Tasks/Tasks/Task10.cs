using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task10
    {
        public static void Main10(string[] args)
        {
            int i, var1, sum = 0;

            Console.Write("Enter any number : ");
            int number = int.Parse(Console.ReadLine());

            for (i = number; number != 0; number /= 10)
            {
                var1 = number % 10;
                sum = sum * 10 + var1;
            }

            if (i == sum)
            {
                Console.Write("{0} is a palindrome number.", i);
            }
            else
            {
                Console.Write("{0} is not a palindrome number.", i);
            }
        }
    }
}
