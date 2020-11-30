using Foundation.Repositories;
using DataAccessLayer;
using Foundation.Context;

namespace Foundation.UnitOfworks
{
    public class FoundationUnitOfWork : UnitOfWork, IFoundationUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }

        public FoundationUnitOfWork(ApplicationDbContext context,
            StudentRepository studentRepository)
            : base(context)
        {
            StudentRepository = studentRepository;
        }
    }
}
