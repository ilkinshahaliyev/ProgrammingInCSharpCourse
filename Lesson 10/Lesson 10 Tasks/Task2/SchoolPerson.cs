using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SchoolPerson
    {
        private int _age;
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if ((value > 6) && (value < 50))
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age cannot be less than 6 and more than 50.");
                }
            }
        }
        public DateTime DateOfBirth { get; set; }
        public int CurrentClass { get; set; }

        public void Greet()
        {
            Console.WriteLine("Hello, {0} {1}.", Name, Surname);
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is : {0}.", Age);
        }

        public void GoToClasses()
        {
            Console.WriteLine("I am going to class.");
        }
    }
}
