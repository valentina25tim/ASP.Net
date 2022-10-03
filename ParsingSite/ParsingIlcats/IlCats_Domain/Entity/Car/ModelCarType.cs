using System;
using System.Collections.Generic;

namespace IlCats_Domain.Entity.Car
{
    /// <summary>
    /// Выбор моделии (Детали)
    /// </summary>
    public class ModelCarType : Entity
    {
        /// <summary>
        /// Выбор модели / Код
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Выбор модели / Дата (период)
        /// </summary>
        public DateTime ?DateFrom { get; set; }

        /// <summary>
        /// Выбор модели / Дата (период)
        /// </summary>
        public DateTime ?DateTo { get; set; }

        /// <summary>
        /// Выбор модели / Комплектация
        /// </summary>
        public string ?Complectation { get; set; }

        /// <summary>
        /// Выбор модели ref(==Code) => Выбор комплектации автомобиля
        /// </summary>
        public IEnumerable< ComplectationVariable> ?ComplectationVariables { get; set; }
        public int ModelCarId { get; set; }
    }
}
