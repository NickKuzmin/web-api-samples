using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Domain.ApiModels;

namespace WebApi.Domain.Services.Interfaces
{
    public interface IPersonDataProvider
    {
        Task<List<PersonApiModel>> GetAsync(CancellationToken cancellationToken);

        Task<int> CreateAsync(PersonApiModel personApiModel, CancellationToken cancellationToken);
    }
}
