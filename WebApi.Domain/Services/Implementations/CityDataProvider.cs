using System;
using System.Collections.Generic;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Domain.Services.Implementations
{
    public class CityDataProvider : ICityDataProvider
    {
        public IEnumerable<CityApiModel> Get()
        {
            return Array.Empty<CityApiModel>();
        }
    }
}
