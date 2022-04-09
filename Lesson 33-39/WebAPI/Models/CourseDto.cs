using System;

namespace WebAPI.Models
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreationTime { get; set; }
    }
}
