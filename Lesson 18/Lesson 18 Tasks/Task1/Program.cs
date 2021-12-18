using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Ilkin");
            myList.Add("Nurlan");
            myList.Add("Babek");
            myList.Add("Ibrahim");

            var isTrue = myList.WhereMy("Nurlan");
            var isTrue2 = myList.WhereMy("Samir");

            Console.WriteLine(isTrue);
            Console.WriteLine(isTrue2);

            Console.WriteLine("----------");

            Console.WriteLine(myList.FirstOrDefaultMy());

            Console.ReadKey();
        }

        public static string ListAsString(List<string> list)
        {
            string str = string.Empty;

            foreach (var item in list)
            {
                str += item + " ";
            }

            return str;
        }
    }
}
