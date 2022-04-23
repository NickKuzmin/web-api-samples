using System;
using System.Collections.Generic;
using WebApi.Domain.Services.Interfaces;
using WebApi.Samples.ApiModels;

namespace WebApi.Domain.Services.Implementations
{
    public class PersonDataProvider : IPersonDataProvider
    {
        public IEnumerable<PersonApiModel> Get()
        {
            return Array.Empty<PersonApiModel>();
        }
    }
}
