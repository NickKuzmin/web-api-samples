using System.Collections.Generic;
using WebApi.Samples.ApiModels;

namespace WebApi.Domain.Services.Interfaces
{
    public interface IPersonDataProvider
    {
        IEnumerable<PersonApiModel> Get();
    }
}
