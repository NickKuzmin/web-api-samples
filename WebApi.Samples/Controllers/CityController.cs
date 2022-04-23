using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CuttingEdge.Conditions;
using WebApi.Domain.Services.Interfaces;
using WebApi.Samples.ApiModels;

namespace WebApi.Samples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityDataProvider _cityDataProvider;

        public CityController(ICityDataProvider cityDataProvider)
        {
            Condition.Requires(cityDataProvider).IsNotNull(nameof(cityDataProvider));
            _cityDataProvider = cityDataProvider;
        }

        [HttpGet]
        public IEnumerable<CityApiModel> Get()
        {
            return _cityDataProvider.Get();
        }
    }
}
