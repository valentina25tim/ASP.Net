using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABP_Entity.Entities.Car;

namespace ABP_Dal.Repositories
{
    public interface ICarRepository<T> : IModelRepository<Car>
    {
    }
}
