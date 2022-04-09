using System.Threading.Tasks;
using WebAPI.Data.Entities;
using WebAPI.Repository;

namespace WebAPI.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IGenericRepository<Student, int> StudentRepository { get; set; }
        public Task Commit();
    }
}
