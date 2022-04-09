using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Data.Entities
{
    //[Table("tblCourses")]
    public class Course : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreationTime { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
