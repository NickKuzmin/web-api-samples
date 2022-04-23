using System.Collections.Generic;
using MediatR;
using WebApi.Domain.ApiModels;

namespace WebApi.Samples.Commands
{
    public class GetCitiesCommand : IRequest<IEnumerable<CityApiModel>>
    {
    }
}
