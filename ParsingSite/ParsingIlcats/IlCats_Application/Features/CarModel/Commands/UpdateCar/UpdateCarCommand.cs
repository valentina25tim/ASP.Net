using IlCats_Application.Features.CarModel.Models;
using MediatR;

namespace IlCats_Application.Features.CarModel.Commands.UpdateCar
{
    public class UpdateCarCommand : IRequest<ModelCar_Model>
    {
        public int Id { get; set; }
        public ModelCar_Model Model { get; set; }
        public UpdateCarCommand(ModelCar_Model model, int id)
        {
            Model = model;
            Id = id;
        }
    }
}