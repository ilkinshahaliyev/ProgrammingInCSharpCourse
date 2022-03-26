using EFCoreTestAPI.Data;
using EFCoreTestAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTestAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDBContext _studentDBContext;

        public StudentRepository(StudentDBContext studentDBContext)
        {
            _studentDBContext = studentDBContext;
        }

        public async Task<Student> CreateStudent(Student student)
        {
            await _studentDBContext.Students.AddAsync(student);

            await _studentDBContext.SaveChangesAsync();

            return student;
        }

        public async Task<Student> DeleteStudent(int id)
        {
            var student = await _studentDBContext.Students.FindAsync(id);

            _studentDBContext.Students.Remove(student);

            await _studentDBContext.SaveChangesAsync();

            return student;
        }

        public async Task<Student> GetStudentById(int id)
        {
            var student = await _studentDBContext.Students.FindAsync(id);

            return student;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = await _studentDBContext.Students.ToListAsync();

            return students;
        }

        public async Task<Student> UpdateStudent(int id, Student newStudent)
        {
            var student = await _studentDBContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            _studentDBContext.Entry(student).CurrentValues.SetValues(newStudent);

            await _studentDBContext.SaveChangesAsync();

            return student;
        }
    }
}
