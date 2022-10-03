using AutoMapper;
using IlCats_Application.Contracts;
using IlCats_Application.Features.CarModel.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IlCats_Application.Features.CarModel.Commands.DeleteCar
{
    public class DeleteCarCommandHandler : IRequestHandler <DeleteCarCommand, ModelCar_Model>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<IlCats_Domain.Entity.Car.ModelCar> _repository;

        public DeleteCarCommandHandler(IAsyncRepository<IlCats_Domain.Entity.Car.ModelCar> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ModelCar_Model> Handle(DeleteCarCommand command, CancellationToken cancellationToken)
        {
            var carFind = await _repository.GetByIdAsync(command.Id, cancellationToken);

            var carEntity= _mapper.Map<IlCats_Domain.Entity.Car.ModelCar>(carFind);

            var carDelete = await _repository.DeleteAsync(carEntity, cancellationToken);
           
            return _mapper.Map<ModelCar_Model>(carDelete);
        }
    }
}
