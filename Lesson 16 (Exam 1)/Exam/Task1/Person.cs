using System;
using System.Collections.Generic;

namespace Task1
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Person> ChildPerson { get; set; }
        public Person ParentPerson { get; set; }
    }
}
