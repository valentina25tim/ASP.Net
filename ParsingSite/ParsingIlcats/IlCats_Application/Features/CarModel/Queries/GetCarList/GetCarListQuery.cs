using System.Collections.Generic;
using IlCats_Application.Features.CarModel.Models;
using MediatR;

namespace IlCats_Application.Features.CarModel.Queries.GetCarList
{
    public class GetCarListQuery : IRequest<List<ModelCar_Model>>
    {
        public string Name { get; set; }
    }
}
 