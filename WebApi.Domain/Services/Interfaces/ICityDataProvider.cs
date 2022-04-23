using System.Collections.Generic;
using WebApi.Domain.ApiModels;

namespace WebApi.Domain.Services.Interfaces
{
    public interface ICityDataProvider
    {
        IEnumerable<CityApiModel> Get();
    }
}
