using System.Collections.Generic;

namespace IlCats_Domain.Entity.Car
{
    /// <summary>
    /// Выбор модели (заголовок)
    /// </summary>
    public class ModelCar : Entity
    {
        /// <summary>
        /// Выбор модели / Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Выбор модели / Детали 
        /// </summary>
        public IEnumerable<ModelCarType> ? ModelTypes { get; set;}
    }
}
