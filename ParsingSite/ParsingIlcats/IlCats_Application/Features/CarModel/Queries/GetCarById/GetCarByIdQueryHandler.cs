using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using IlCats_Application.Contracts;
using IlCats_Application.Features.CarModel.Models;
using MediatR;

namespace IlCats_Application.Features.CarModel.Queries.GetCarById
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, ModelCar_Model>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<IlCats_Domain.Entity.Car.ModelCar> _repository;

        public GetCarByIdQueryHandler(IAsyncRepository<IlCats_Domain.Entity.Car.ModelCar> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ModelCar_Model> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var car = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return _mapper.Map<ModelCar_Model>(car);
        }
    }
}