using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using Microsoft.EntityFrameworkCore;
using WebApi.Domain.ApiModels;
using WebApi.Domain.DataContext;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Domain.Services.Implementations
{
    public class CityDataProvider : ICityDataProvider
    {
        private readonly ApplicationContext _applicationContext;

        public CityDataProvider(ApplicationContext applicationContext)
        {
            Condition.Requires(applicationContext).IsNotNull(nameof(applicationContext));
            _applicationContext = applicationContext;
        }

        public async Task<List<CityApiModel>> GetAsync(CancellationToken cancellationToken)
        {
            await using var context = _applicationContext;

            return await context.Cities.Select(x => new CityApiModel
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync(cancellationToken);
        }
    }
}
