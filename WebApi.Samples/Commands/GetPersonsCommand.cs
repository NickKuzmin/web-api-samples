using System.Collections.Generic;
using MediatR;
using WebApi.Domain.ApiModels;

namespace WebApi.Samples.Commands
{
    public class GetPersonsCommand : IRequest<List<PersonApiModel>>
    {
    }
}
