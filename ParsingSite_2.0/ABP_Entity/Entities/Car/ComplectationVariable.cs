using System;
using System.Collections.Generic;


namespace ABP_Entity.Entities.Car
{
    /// <summary>
    /// Выбор комплектации автомобиля (заголовок)
    /// </summary>
    public class ComplectationVariable : BaseEntity
    {
        public string Complectation { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string Engine { get; set; }

        public string Grade { get; set; }

        public string AtmMtm { get; set; }

        public string GearShiftType { get; set; }

        public string DriversPosition { get; set; }

        public string FuelInduction { get; set; }

        public IEnumerable<SparePart> ?SpareParts { get; set; }
        public int ModelCarTypeId { get; set; }
    }
}
