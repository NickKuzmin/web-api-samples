using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using MediatR;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Samples.Commands
{
    public class GetPersonsCommandHandler : IRequestHandler<GetPersonsCommand, List<PersonApiModel>>
    {
        private readonly IPersonDataProvider _personDataProvider;

        public GetPersonsCommandHandler(IPersonDataProvider personDataProvider)
        {
            Condition.Requires(personDataProvider).IsNotNull(nameof(personDataProvider));
            _personDataProvider = personDataProvider;
        }

        public async Task<List<PersonApiModel>> Handle(GetPersonsCommand request, CancellationToken cancellationToken)
        {
            return await _personDataProvider.GetAsync(cancellationToken);
        }
    }
}
