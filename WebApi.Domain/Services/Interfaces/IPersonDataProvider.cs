using System.Collections.Generic;
using WebApi.Domain.ApiModels;

namespace WebApi.Domain.Services.Interfaces
{
    public interface IPersonDataProvider
    {
        IEnumerable<PersonApiModel> Get();

        PersonApiModel Create(PersonApiModel personApiModel);
    }
}
