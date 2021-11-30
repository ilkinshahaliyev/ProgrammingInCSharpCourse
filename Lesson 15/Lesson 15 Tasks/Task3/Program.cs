using System;
using System.Collections.Generic;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Ilkin", 19);
            people.Add("Nurlan", 28);

            var firstItem = people.GetEnumerator();
            firstItem.MoveNext();
            var currentItem = firstItem.Current;

            Console.WriteLine("{0} - {1}", currentItem.Key, currentItem.Value);
        }
    }
}
