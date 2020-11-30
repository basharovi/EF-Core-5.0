using System.Collections.Generic;

namespace Foundation.Entities
{
    public class Department : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Lab> Labs { get; set; }
    }
}
