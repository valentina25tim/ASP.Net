using IlCats_Application.Features.CarModel.Models;
using MediatR;

namespace IlCats_Application.Features.CarModel.Commands.DeleteCar
{
    public class DeleteCarCommand : IRequest<ModelCar_Model>
    {
        public int Id { get; set; }
    }
}
