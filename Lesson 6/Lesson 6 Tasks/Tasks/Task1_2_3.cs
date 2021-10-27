using System;

namespace Tasks
{
    class Task1_2_3
    {
        static void Main1_2_3(string[] args)
        {
            Random random = new Random();

            Console.Write("Enter a number between 10 and 100 : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                numbers[i] = random.Next(1, 101);
                Console.WriteLine("x[{0}] = {1}", i, numbers[i]);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Ascending array : ");

            Array.Sort(numbers);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Descending array : ");

            Array.Reverse(numbers);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("The 3rd max element of array is {0}.", numbers[2]);

            Console.WriteLine("---------------");

            Console.WriteLine("The first 4 max elements of array : ");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
