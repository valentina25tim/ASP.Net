using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using IlCats_Application.Contracts;
using IlCats_Application.Features.CarModel.Models;
using MediatR;

namespace IlCats_Application.Features.CarModel.Commands.CreateCar
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, ModelCar_Model>
    {
        private readonly IMapper _mapper;
        private readonly IModelCarRepository _carRepository;

        public CreateCarCommandHandler(IModelCarRepository personRepository, IMapper mapper)
        {
            _carRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<ModelCar_Model> Handle(CreateCarCommand command, CancellationToken cancellationToken)
        {
            var validationResult = await new CreateCarCommandValidator()
                .ValidateAsync(command, cancellationToken);

            if (validationResult.IsValid)
            {
                ModelCar_Model car = command.Model;

                var newCar = new ModelCar_Model
                {
                    Name = car.Name
                };

                var thisCar = await _carRepository.AddAsync(_mapper.Map<IlCats_Domain.Entity.Car.ModelCar>(newCar), cancellationToken);
                return newCar;
            }

            throw new ValidationException("set validation result message");
        }
        
}
}