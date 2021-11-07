using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;    
        }

        public override string ToString()
        {
            return $"My name is {Name}";
        }

        ~Person()
        {
            Name = "";
        }
    }
}
