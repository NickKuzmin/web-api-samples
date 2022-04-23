using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using MediatR;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Samples.Commands
{
    public class GetCitiesCommandHandler : IRequestHandler<GetCitiesCommand, IEnumerable<CityApiModel>>
    {
        private readonly ICityDataProvider _cityDataProvider;

        public GetCitiesCommandHandler(ICityDataProvider cityDataProvider)
        {
            Condition.Requires(cityDataProvider).IsNotNull(nameof(cityDataProvider));
            _cityDataProvider = cityDataProvider;
        }

        public Task<IEnumerable<CityApiModel>> Handle(GetCitiesCommand request, CancellationToken cancellationToken)
        {
            return _cityDataProvider.GetAsync();
        }
    }
}
