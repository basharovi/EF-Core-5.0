using System.Collections.Generic;

namespace Foundation.Entities
{
    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNo { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
