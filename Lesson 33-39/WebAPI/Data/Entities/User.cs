using System;

namespace WebAPI.Data.Entities
{
    public class User : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
