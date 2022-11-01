using System.Collections.Generic;

namespace ABP_Entity.Entities.Car
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<CarType> ? ModelTypes { get; set;}
    }
}
