using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.ApiModels;

namespace WebApi.Domain.Services.Interfaces
{
    public interface IPersonDataProvider
    {
        Task<IEnumerable<PersonApiModel>> GetAsync();

        Task<PersonApiModel> CreateAsync(PersonApiModel personApiModel);
    }
}
