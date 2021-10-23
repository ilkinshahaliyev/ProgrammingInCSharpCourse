using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task3
    {
        static void Main3()
        {
            Console.Write("Enter 1st number : ");
            float number1 = float.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number : ");
            float number2 = float.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number : ");
            float number3 = float.Parse(Console.ReadLine());

            Console.Write("Enter 4th number : ");
            float number4 = float.Parse(Console.ReadLine());

            Console.Write("Enter 5th number : ");
            float number5 = float.Parse(Console.ReadLine());

            float sum = number1 + number2 + number3 + number4 + number5;
            Console.WriteLine(sum);

            float average = sum / 5;
            Console.WriteLine(average);
        }
    }
}
