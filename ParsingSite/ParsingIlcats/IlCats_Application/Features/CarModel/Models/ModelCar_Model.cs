using System;
using System.Collections.Generic;
using System.Text;

namespace IlCats_Application.Features.CarModel.Models
{
    public class ModelCar_Model: BaseTrace_Model
    {
        /// <summary>
        /// Выбор модели / Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Выбор модели / Детали 
        /// </summary>
        //public IEnumerable<ModelCarType_Model>? ModelTypes { get; set; }
    }
}
