using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string? Gender { get; set; }
        public string? Adress { get; set; }

        public override string ToString()
        {
            return $"Student id : {Id}, Student name : {Name}, " +
                $"Student surname : {Surname}, Student bithdate : {DateOfBirth:dd.MM.yyyy}, " +
                $"Student nationality : {Nationality}, Student gender : {Gender}, " +
                $"Student adress : {Adress}.";
        }
    }
}
