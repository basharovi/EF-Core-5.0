using DataAccessLayer;
using System.Collections.Generic;

namespace Foundation.Entities
{
    public class Course : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credit { get; set; }
        public IList<Student> Students { get; set; }
    }
}
