using System.Collections.Generic;

namespace EFCoreCrud.Models.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credit { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
    }
}
