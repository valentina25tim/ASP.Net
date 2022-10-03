using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using IlCats_Application.Contracts;
using IlCats_Application.Features.CarModel.Models;
using MediatR;


namespace IlCats_Application.Features.CarModel.Queries.GetCarList
{
    public class GetCarListQueryHandler : IRequestHandler<GetCarListQuery, List<ModelCar_Model>>
    {
        private readonly IAsyncRepository<IlCats_Domain.Entity.Car.ModelCar> _repository;
        private readonly IMapper _mapper;

        public GetCarListQueryHandler(IAsyncRepository<IlCats_Domain.Entity.Car.ModelCar> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ModelCar_Model>> Handle(GetCarListQuery request, CancellationToken cancellationToken)
        { 
            var cars = await _repository.ListAllAsync(cancellationToken);
            return _mapper.Map<List<ModelCar_Model>>(cars);
        }
    }
}
