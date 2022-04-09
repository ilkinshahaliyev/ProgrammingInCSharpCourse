using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class StudentDto
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [Range(0, 200)]
        public double Salary { get; set; }
    }
}
