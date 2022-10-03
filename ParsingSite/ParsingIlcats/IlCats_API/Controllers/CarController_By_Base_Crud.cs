using AutoMapper;
using IlCats_Application.Features.CarModel.Models;
using IlCats_Application.Features.CarModel.Queries.GetCarById;
using IlCats_Application.Features.CarModel.Queries.GetCarList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IlCats_API_Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CompanyCrudController_ByBase : BaseCrudController<
            ModelCar_Model,
            IlCats_Domain.Entity.Car.ModelCar,
            GetCarListQuery,
            GetCarByIdQuery>

    {
        public CompanyCrudController_ByBase(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}
