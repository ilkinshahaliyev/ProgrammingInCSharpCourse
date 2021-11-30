using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine(myList.Count);

            //myList.Clear();

            //Console.WriteLine(myList.GetElementByIndex(2));

            int sum = 0;

            foreach (var item in myList)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
