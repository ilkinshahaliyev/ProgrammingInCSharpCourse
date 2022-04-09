using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Data.Entities;

namespace WebAPI.Repository
{
    public interface IStudentRepository
    {
        Task<Student> Get(int id);

        Task<IEnumerable<Student>> GetAll();

        Task<Student> Add(Student entity);

        Task<Student> Delete(int id);

        Task<Student> Update(Student entity);
    }
}
