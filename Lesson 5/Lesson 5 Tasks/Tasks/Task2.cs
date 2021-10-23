using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task2
    {
        static void Main2()
        {
            int sum = 0;

            for (int i = 1; i < 20; i+=2)
            {
                Console.WriteLine(i);

                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
