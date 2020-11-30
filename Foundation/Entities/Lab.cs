using System.Collections.Generic;

namespace Foundation.Entities
{
    public class Lab : IEntity<int>
    {
        public int Id { get; set; }
        public string LabNo { get; set; }
        public IList<Department> Departments { get; set; }
    }
}
