using AutoMapper;
using FluentValidation;
using IlCats_Application.Contracts;
using IlCats_Application.Features.CarModel.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IlCats_Application.Features.CarModel.Commands.UpdateCar
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, ModelCar_Model>
    {
        private readonly IMapper _mapper;
        private readonly IModelCarRepository _carRepository;

        public UpdateCarCommandHandler(IMapper mapper, IModelCarRepository personRepository)
        {
            _mapper = mapper;
            _carRepository = personRepository;
        }

        public async Task<ModelCar_Model> Handle(UpdateCarCommand command, CancellationToken cancellationToken)
        {
            var validationResult = await new UpdateCarCommandValidator()
                .ValidateAsync(command, cancellationToken);

            if (validationResult.IsValid)
            {
                var carBefore = await _carRepository.GetByIdAsync(command.Id, cancellationToken);

                var carChange = carBefore;
                {
                    carBefore.Name = command.Model.Name;
                };

                var car = await _carRepository.UpdateAsync(_mapper.Map<IlCats_Domain.Entity.Car.ModelCar>(carChange), cancellationToken);// SaveChangesAsync

                var carAfter = new ModelCar_Model { Name = car.Name };
                
                return carAfter;
            }

            throw new ValidationException("set validation result message");
        }
    }
}
