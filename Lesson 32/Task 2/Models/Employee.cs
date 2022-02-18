using System;

namespace Task_2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public bool IsManager { get; set; }
    }
}
