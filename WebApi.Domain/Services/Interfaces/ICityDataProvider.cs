using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Domain.ApiModels;

namespace WebApi.Domain.Services.Interfaces
{
    public interface ICityDataProvider
    {
        Task<List<CityApiModel>> GetAsync(CancellationToken cancellationToken);
    }
}
