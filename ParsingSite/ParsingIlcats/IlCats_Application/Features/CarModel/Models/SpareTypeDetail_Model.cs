using System;
using System.Collections.Generic;
using System.Text;

namespace IlCats_Application.Features.CarModel.Models
{
    public class SpareTypeDetail_Model
    {
        /// <summary>
        /// Выбор запчасти / Номер (код)
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Выбор запчасти / Кол-во
        /// </summary>
        public int? ModifiedCode { get; set; }

        /// <summary>
        /// Выбор запчасти
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Выбор запчасти / 	Кол-во
        /// </summary>
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Выбор запчасти / Дата
        /// </summary>
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Выбор запчасти / Применяемость
        /// </summary>
        public string Applying { get; set; }

        public int SparePartId { get; set; }
    }
}
