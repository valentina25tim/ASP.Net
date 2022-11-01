using System;


namespace ABP_Entity.Entities.Car
{
    public class SpareTypeDetail : BaseEntity
    {
        public int Code { get; set; }

        public int? ModifiedCode { get; set; }

        public int Quantity { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string Applying { get; set; }

        public int SparePartId { get; set; }
    }
}
