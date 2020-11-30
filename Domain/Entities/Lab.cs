using System.Collections.Generic;

namespace Domain.Entities
{
    public class Lab
    {
        public int Id { get; set; }
        public string LabNo { get; set; }
        public IList<Department> Departments { get; set; }
    }
}
