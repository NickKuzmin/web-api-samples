using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using MediatR;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Samples.Commands
{
    public class GetCitiesCommandHandler : IRequestHandler<GetCitiesCommand, List<CityApiModel>>
    {
        private readonly ICityDataProvider _cityDataProvider;

        public GetCitiesCommandHandler(ICityDataProvider cityDataProvider)
        {
            Condition.Requires(cityDataProvider).IsNotNull(nameof(cityDataProvider));
            _cityDataProvider = cityDataProvider;
        }

        public async Task<List<CityApiModel>> Handle(GetCitiesCommand request, CancellationToken cancellationToken)
        {
            return await _cityDataProvider.GetAsync(cancellationToken);
        }
    }
}
