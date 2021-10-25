using System;

namespace Tasks
{
    class Task9
    {
        public static void Main(string[] args)
        {
            int n, j;
            int var1 = 1, var2 = 1, var3 = 0;

            Console.Write("Enter any number : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 3; i <= n / 2; i++)
            {
                var1 = 1;
                var2 = 1;

                for (j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        var1 = 0;
                        j = i;
                    }
                }

                for (j = 2; j < n - i; j++)
                {
                    if ((n - i) % j == 0)
                    {
                        var2 = 0;
                        j = n - i;
                    }
                }

                if ((var1 == 1) && (var2 == 1))
                {
                    Console.WriteLine("{0} = {1} + {2}", n, i, n - i);
                    var3 = 1;
                }
            }

            if (var3 == 0)
            {
                Console.Write("{0} can't be expressed as sum of two prime numbers.", n);
            }
        }
    }
}
