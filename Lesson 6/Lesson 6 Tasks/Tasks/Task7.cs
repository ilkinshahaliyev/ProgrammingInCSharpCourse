using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task7
    {
        static void Main7(string[] args)
        {
            Console.Write("Enter any text : ");
            string text = Console.ReadLine();

            CountOfSpaces(text);
        }

        static void CountOfSpaces(string text)
        {
            char[] myArray = text.ToCharArray();

            int count = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == ' ')
                {
                    count += 1;
                }
            }

            Console.WriteLine("The count of spaces of your entered text is {0}.", count);
        }
    }
}
