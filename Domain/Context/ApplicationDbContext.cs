using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
