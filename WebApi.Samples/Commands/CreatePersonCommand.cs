using MediatR;
using WebApi.Domain.ApiModels;

namespace WebApi.Samples.Commands
{
    public class CreatePersonCommand : IRequest<PersonApiModel>
    {
        public PersonCreateApiModel PersonCreateApiModel { get; set; }
    }
}
