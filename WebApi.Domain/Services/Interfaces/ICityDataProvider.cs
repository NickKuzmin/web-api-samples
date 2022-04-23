using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.ApiModels;

namespace WebApi.Domain.Services.Interfaces
{
    public interface ICityDataProvider
    {
        Task<IEnumerable<CityApiModel>> GetAsync();
    }
}
