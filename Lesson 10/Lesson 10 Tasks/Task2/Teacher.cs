using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Teacher : SchoolPerson
    {
        public void Explain()
        {
            Console.WriteLine("Explanation begin on subject.");
        }

        public new void GoToClasses()
        {
            Console.WriteLine("I am {0} {1}. I am teacher.", Name, Surname);
        }
    }
}
