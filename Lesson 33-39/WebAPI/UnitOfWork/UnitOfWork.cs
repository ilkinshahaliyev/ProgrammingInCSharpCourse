using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Data.Entities;
using WebAPI.Repository;

namespace WebAPI.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentDbContext _studentDbContext;

        public IGenericRepository<Student, int> StudentRepository { get; set; }

        public UnitOfWork(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
            StudentRepository = new GenericRepository<Student, int>(_studentDbContext);
        }

        public async Task Commit()
        {
            await _studentDbContext.SaveChangesAsync();
        }
    }
}
