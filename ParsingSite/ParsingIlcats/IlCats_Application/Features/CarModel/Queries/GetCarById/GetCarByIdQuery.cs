using IlCats_Application.Features.CarModel.Models;
using MediatR;

namespace IlCats_Application.Features.CarModel.Queries.GetCarById
{
    public class GetCarByIdQuery : IRequest<ModelCar_Model>
    {
        public int Id { get; set; }
    }
} 