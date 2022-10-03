using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IlCats_API_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseCrudController<TModel, TEntity,TGetFeaturesRequest, TGetFeatureDetailQuery> : ControllerBase

        where TModel : class 
        where TEntity : class
        where TGetFeaturesRequest : class, new()
        where TGetFeatureDetailQuery : class, new()

    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;


        public BaseCrudController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet(nameof(ListAllByOrigin), Name = nameof(ListAllByOrigin))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<TModel>>> ListAllByOrigin(CancellationToken ct)
        {
            var response = await _mediator.Send(new TGetFeaturesRequest(), ct);
            var listAll = _mapper.Map<List<TModel>>(response);
            return listAll;
        }
    }
}  
