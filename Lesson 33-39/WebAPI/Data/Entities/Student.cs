using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Data.Entities
{
    //[Table("tblStudents")]
    public class Student : BaseEntity<int>
    {
        //[Key]
        public override int Id { get; set; }

        //[MaxLength(20)]
        public string FirstName { get; set; }

        //[MaxLength(20)]
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public double Salary { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
