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
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            Condition.Requires(mediator).IsNotNull(nameof(mediator));
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonApiModel>> Get([FromBody] GetPersonsCommand getPersonsCommand)
        {
            var result = await _mediator.Send(getPersonsCommand, CancellationToken.None);

            return result;
        }

        [HttpPost]
        public async Task<OkObjectResult> Create([FromBody] CreatePersonCommand createPersonCommand)
        {
            var result = await _mediator.Send(createPersonCommand, CancellationToken.None);

            return Ok(result);
        }
    }
}
