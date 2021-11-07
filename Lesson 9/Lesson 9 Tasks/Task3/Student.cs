using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying.");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is : {0}", age);
        }
    }
}
