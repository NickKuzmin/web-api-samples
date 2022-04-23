using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CuttingEdge.Conditions;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Samples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonDataProvider _personDataProvider;

        public PersonController(IPersonDataProvider personDataProvider)
        {
            Condition.Requires(personDataProvider).IsNotNull(nameof(personDataProvider));
            _personDataProvider = personDataProvider;
        }

        [HttpGet]
        public IEnumerable<PersonApiModel> Get()
        {
            return _personDataProvider.Get();
        }

        [HttpPost]
        public PersonApiModel Create(PersonCreateApiModel personCreateApiModel)
        {
            var personApiModel = new PersonApiModel();

            return _personDataProvider.Create(personApiModel);
        }
    }
}
