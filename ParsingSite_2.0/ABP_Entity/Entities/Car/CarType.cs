using System;
using System.Collections.Generic;

namespace ABP_Entity.Entities.Car
{
    public class CarType : BaseEntity
    {
        public string Code { get; set; }

        public DateTime ?DateFrom { get; set; }

        public DateTime ?DateTo { get; set; }

        public string ?Complectation { get; set; }

        public IEnumerable< ComplectationVariable> ?ComplectationVariables { get; set; }
        public int ModelCarId { get; set; }
    }
}
