using System;
using System.Collections.Generic;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Domain.Services.Implementations
{
    public class PersonDataProvider : IPersonDataProvider
    {
        public IEnumerable<PersonApiModel> Get()
        {
            return Array.Empty<PersonApiModel>();
        }

        public PersonApiModel Create(PersonApiModel personApiModel)
        {
            throw new NotImplementedException();
        }
    }
}
