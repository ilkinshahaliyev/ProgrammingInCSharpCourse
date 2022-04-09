using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Data.Entities;

namespace WebAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _studentDbContext;

        public StudentRepository(StudentDbContext context)
        {
            _studentDbContext = context;
        }

        public async Task<Student> Add(Student entity)
        {
            await _studentDbContext.Students.AddAsync(entity);
            await _studentDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Student> Delete(int id)
        {
            var student = await _studentDbContext.Students.FindAsync(id);

            _studentDbContext.Students.Remove(student);
            await _studentDbContext.SaveChangesAsync();

            return student;
        }

        public async Task<Student> Get(int id)
        {
            return await _studentDbContext.Students.FindAsync(id);
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _studentDbContext.Students.ToListAsync();
        }

        public async Task<Student> Update(Student entity)
        {
            _studentDbContext.Entry(entity).State = EntityState.Modified;
            await _studentDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
