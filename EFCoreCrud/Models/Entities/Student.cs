using System.Collections.Generic;

namespace EFCoreCrud.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNo { get; set; }
        public Department Department { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
    }
}
