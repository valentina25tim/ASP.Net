using System.Collections.Generic;

namespace IlCats_Domain.Entity.Car
{
    /// <summary>
    /// Выбор запчасти (заголовок)
    /// </summary>
    public class SparePart : Entity
    {
        public string Name { get; set; }

        public IEnumerable<SpareTypeDetail> ?SpareTypeDetails { get; set; } 
        public int ComplectationVariableId { get; set; }
    }
}
