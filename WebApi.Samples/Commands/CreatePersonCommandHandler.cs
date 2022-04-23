using System.Threading;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using MediatR;
using WebApi.Domain.ApiModels;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Samples.Commands
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, PersonApiModel>
    {
        private readonly IPersonDataProvider _personDataProvider;

        public CreatePersonCommandHandler(IPersonDataProvider personDataProvider)
        {
            Condition.Requires(personDataProvider).IsNotNull(nameof(personDataProvider));
            _personDataProvider = personDataProvider;
        }

        public Task<PersonApiModel> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var personApiModel = new PersonApiModel
            {
                Phone = request.PersonCreateApiModel.Phone,
                Email = request.PersonCreateApiModel.Email,
                City = request.PersonCreateApiModel.City
            };

            return _personDataProvider.CreateAsync(personApiModel);
        }
    }
}
