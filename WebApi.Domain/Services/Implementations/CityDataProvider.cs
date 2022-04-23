using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Domain.Services.Implementations
{
    public class CityDataProvider : ICityDataProvider
    {
        public Task<IEnumerable<CityApiModel>> GetAsync()
        {
            IEnumerable<CityApiModel> result = new List<CityApiModel>
            {
                new()
                {
                    Id = Guid.Empty,
                    Name = "Some #1"
                },
                new()
                {
                    Id = Guid.Empty,
                    Name = "Some #2"
                }
            };
            return Task.FromResult(result);
        }
    }
}
