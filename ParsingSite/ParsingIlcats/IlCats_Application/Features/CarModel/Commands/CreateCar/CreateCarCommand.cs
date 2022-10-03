using IlCats_Application.Features.CarModel.Models;
using MediatR;

namespace IlCats_Application.Features.CarModel.Commands.CreateCar
{
    public class CreateCarCommand : IRequest<ModelCar_Model>
    {
        public ModelCar_Model Model { get; set; }
        public CreateCarCommand(ModelCar_Model car)
        {
            Model = car;
        }
    }
}