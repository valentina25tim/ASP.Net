using System;
using System.Collections.Generic; 

namespace IlCats_Domain.Entity.Car
{
    /// <summary>
    /// Выбор комплектации автомобиля (заголовок)
    /// </summary>
    public class ComplectationVariable : Entity
    {
        /// <summary>
        /// Выбор комплектации автомобиля / Комплектация
        /// </summary>
        public string Complectation { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля / Дата
        /// </summary>
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля / Дата
        /// </summary>
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля / ENGINE 1
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля / GRADE
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля / ATM,MTM
        /// </summary>
        public string AtmMtm { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля / GEAR SHIFT TYPE
        /// </summary>
        public string GearShiftType { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля / DRIVER'S POSITION
        /// </summary>
        public string DriversPosition { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля / FUEL INDUCTION
        /// </summary>
        public string FuelInduction { get; set; }

        /// <summary>
        /// Выбор комплектации автомобиля ref => Выбор запчасти
        /// </summary>
        public IEnumerable<SparePart> ?SpareParts { get; set; }
        public int ModelCarTypeId { get; set; }
    }
}
