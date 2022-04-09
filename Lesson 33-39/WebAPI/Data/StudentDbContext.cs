using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Entities;

namespace WebAPI.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().ToTable("tblStudents");
            modelBuilder.Entity<Course>().ToTable("tblCourses");
            modelBuilder.Entity<StudentCourse>().ToTable("tblStudentCourses");
            modelBuilder.Entity<User>().ToTable("tblUsers");

            modelBuilder.Entity<StudentCourse>().HasKey(x => new { x.StudentId, x.CourseId });

            modelBuilder.Entity<Student>().Property(x => x.FirstName).HasMaxLength(25);
            modelBuilder.Entity<Student>().Property(x => x.LastName).HasMaxLength(25);

            modelBuilder.Entity<User>().Property(x=>x.FullName).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(x=>x.Password).HasMaxLength(20);
        }
    }
}
