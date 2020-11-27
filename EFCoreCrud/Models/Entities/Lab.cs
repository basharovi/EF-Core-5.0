using System.Collections.Generic;

namespace EFCoreCrud.Models.Entities
{
    public class Lab
    {
        public int Id { get; set; }
        public string LabNo { get; set; }
        public IList<Department> Departments { get; set; }
    }
}
