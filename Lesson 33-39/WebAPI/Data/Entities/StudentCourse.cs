using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Data.Entities
{
    //[Table("tblStudentCourses")]
    public class StudentCourse : BaseEntity<int>
    {
        public override int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        //[ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }

        //[ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }
    }
}
