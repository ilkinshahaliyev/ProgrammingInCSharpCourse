using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task8
    {
        public static void Main8(string[] args)
        {
            Console.Write("Please enter any number for find prime numbers of this number : ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            Console.Write("These are prime numbers : ");

            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j <= number; j++)
                {
                    if ((i != j) && (i % j == 0))
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write("{0} ", i);
                }

                isPrime = true;
            }
        }
    }
}
