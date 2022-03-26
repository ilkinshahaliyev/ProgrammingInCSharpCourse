using System.Collections.Generic;

namespace EFCoreTestAPI.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
