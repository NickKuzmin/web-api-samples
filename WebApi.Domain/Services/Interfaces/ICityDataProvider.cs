using System.Collections.Generic;
using WebApi.Samples.ApiModels;

namespace WebApi.Domain.Services.Interfaces
{
    public interface ICityDataProvider
    {
        IEnumerable<CityApiModel> Get();
    }
}
