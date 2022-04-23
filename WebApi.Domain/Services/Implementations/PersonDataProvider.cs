using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Domain.Services.Implementations
{
    public class PersonDataProvider : IPersonDataProvider
    {
        public Task<IEnumerable<PersonApiModel>> GetAsync()
        {
            IEnumerable<PersonApiModel> result = new List<PersonApiModel>
            {
                new()
                {
                    Id = Guid.Empty,
                    City = "City #1",
                    Email = "Email #1",
                    Phone = "Phone #1"
                },
                new()
                {
                    Id = Guid.Empty,
                    City = "City #2",
                    Email = "Email #2",
                    Phone = "Phone #2"
                }
            };

            return Task.FromResult(result);
        }

        public Task<PersonApiModel> CreateAsync(PersonApiModel personApiModel)
        {
            return Task.FromResult(new PersonApiModel());
        }
    }
}
