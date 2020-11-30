using System.Collections.Generic;

namespace Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Lab> Labs { get; set; }
    }
}
