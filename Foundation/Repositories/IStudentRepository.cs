using DataAccessLayer;
using Foundation.Context;
using Foundation.Entities;

namespace Foundation.Repositories
{
    public interface IStudentRepository : IRepository<Student, int, ApplicationDbContext>
    {

    }
}
