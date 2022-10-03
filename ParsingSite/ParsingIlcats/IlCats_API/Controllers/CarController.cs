using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using IlCats_Application.Features.CarModel.Commands.CreateCar;
using IlCats_Application.Features.CarModel.Commands.DeleteCar;
using IlCats_Application.Features.CarModel.Commands.UpdateCar;
using IlCats_Application.Features.CarModel.Models;
using IlCats_Application.Features.CarModel.Queries.GetCarById;
using IlCats_Application.Features.CarModel.Queries.GetCarList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace IlCats_API_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CarController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet(nameof(ListAll), Name = nameof(ListAll))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ModelCar_Model>>> ListAll(CancellationToken ct)
        {
            return await _mediator.Send(new GetCarListQuery(), ct);
        }

        [HttpGet("FindOne/{id}", Name = nameof(FindOne))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ModelCar_Model>> FindOne(int id, CancellationToken ct)
        {
            return await _mediator.Send(new GetCarByIdQuery { Id = id }, ct);
        }

        [HttpPost(nameof(Add), Name = nameof(Add))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ModelCar_Model>> Add([FromBody] ModelCar_Model person, CancellationToken ct)
        {
            return await _mediator.Send(new CreateCarCommand(person));
        }

        [HttpPut("Update/{id}", Name = nameof(Update))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ModelCar_Model>> Update(int id, [FromBody] ModelCar_Model car, CancellationToken ct)
        {
            return await _mediator.Send(new UpdateCarCommand(car, id) { Id = id }, ct);
        }

        [HttpDelete("Delete/{id}", Name = nameof(Delete))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ModelCar_Model>>Delete(int id, CancellationToken ct)
        {
            return await _mediator.Send(new DeleteCarCommand { Id = id}, ct);
        }

    }
}