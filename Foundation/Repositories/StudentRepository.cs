using DataAccessLayer;
using Foundation.Context;
using Foundation.Entities;

namespace Foundation.Repositories
{
    public class StudentRepository : Repository<Student, int, ApplicationDbContext>,
        IStudentRepository
        
    {
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
