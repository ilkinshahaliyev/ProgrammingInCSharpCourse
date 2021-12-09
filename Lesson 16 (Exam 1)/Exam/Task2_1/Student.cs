using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Print()
        {
            return $"Student id is : {Id}, name is : {Name}, surname is : {Surname}, date of birth is {DateOfBirth:dd.MM.yyyy}\n";
        }
    }
}
