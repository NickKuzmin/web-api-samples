using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using MediatR;
using WebApi.Domain.ApiModels;
using WebApi.Samples.Commands;

namespace WebApi.Samples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            Condition.Requires(mediator).IsNotNull(nameof(mediator));
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<CityApiModel>> Get(CancellationToken cancellationToken)
        {
            var getCitiesCommand = new GetCitiesCommand();
            var result = await _mediator.Send(getCitiesCommand, cancellationToken);

            return result;
        }
    }
}
