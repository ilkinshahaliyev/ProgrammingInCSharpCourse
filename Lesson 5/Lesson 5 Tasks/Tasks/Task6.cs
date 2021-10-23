using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task6
    {
        static void Main6()
        {
            Console.Write("Enter count of rows : ");
            int number = int.Parse(Console.ReadLine());

            int k = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", k++);
                }

                Console.WriteLine();
            }
        }
    }
}
