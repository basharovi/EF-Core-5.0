using System.Collections.Generic;

namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNo { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
