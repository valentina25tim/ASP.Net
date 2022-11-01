using System.Collections.Generic;


namespace ABP_Entity.Entities.Car
{
    public class SparePart : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<SpareTypeDetail> ?SpareTypeDetails { get; set; } 
        public int ComplectationVariableId { get; set; }
    }
}
