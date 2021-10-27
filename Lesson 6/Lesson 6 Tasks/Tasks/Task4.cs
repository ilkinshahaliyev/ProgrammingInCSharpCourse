using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task4
    {
        static void Main4(string[] args)
        {
            Console.Write("Enter number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            ChangePlaceOfNumbers(num1, num2);
        }

        static void ChangePlaceOfNumbers(params int[] numbers)
        {
            Array.Reverse(numbers);

            foreach (var nums in numbers)
            {
                Console.Write("{0} ", nums);
            }
        }
    }
}
