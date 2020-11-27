using System.Collections.Generic;

namespace EFCoreCrud.Models.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Student> Students { get; set; }
    }
}
