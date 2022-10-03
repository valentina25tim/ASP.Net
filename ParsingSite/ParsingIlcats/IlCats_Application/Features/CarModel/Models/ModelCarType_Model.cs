using System;
using System.Collections.Generic;
using System.Text;

namespace IlCats_Application.Features.CarModel.Models
{
    public class ModelCarType_Model
    {
        /// <summary>
        /// Выбор модели / Код
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Выбор модели / Дата (период)
        /// </summary>
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Выбор модели / Дата (период)
        /// </summary>
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Выбор модели / Комплектация
        /// </summary>
        public string? Complectation { get; set; }

        /// <summary>
        /// Выбор модели ref(==Code) => Выбор комплектации автомобиля
        /// </summary>
        public IEnumerable<ComplectationVariable_Model>? ComplectationVariables { get; set; }
        public int ModelCarId { get; set; }
    }
}
