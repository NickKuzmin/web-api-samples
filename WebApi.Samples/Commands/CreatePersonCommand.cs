using MediatR;
using WebApi.Domain.ApiModels;

namespace WebApi.Samples.Commands
{
    public class CreatePersonCommand : IRequest<int>
    {
        public PersonCreateApiModel PersonCreateApiModel { get; set; }
    }
}
