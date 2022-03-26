using EFCoreTestAPI.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreTestAPI.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetStudentById(int id);
        Task<Student> CreateStudent(Student student);
        Task<Student> UpdateStudent(int id, Student student);
        Task<Student> DeleteStudent(int id);
    }
}
