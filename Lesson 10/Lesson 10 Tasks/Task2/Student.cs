using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : SchoolPerson
    {
        public new void GoToClasses()
        {
            Console.WriteLine("I am {0} {1}. I am student and i am going to class.", Name, Surname);
        }
    }
}
