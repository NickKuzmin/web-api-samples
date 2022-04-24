using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using Microsoft.EntityFrameworkCore;
using WebApi.Domain.ApiModels;
using WebApi.Domain.DataContext;
using WebApi.Domain.Entities;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Domain.Services.Implementations
{
    public class PersonDataProvider : IPersonDataProvider
    {
        private readonly ApplicationContext _applicationContext;

        public PersonDataProvider(ApplicationContext applicationContext)
        {
            Condition.Requires(applicationContext).IsNotNull(nameof(applicationContext));
            _applicationContext = applicationContext;
        }

        public async Task<List<PersonApiModel>> GetAsync(CancellationToken cancellationToken)
        {
            using var context = _applicationContext;

            return await context.Persons.Select(x => new PersonApiModel
            {
                    Id = x.Id,
                    Phone = x.Phone,
                    Email = x.Email,
                    FullName = x.FullName,
                    City = x.City
            }).ToListAsync(cancellationToken);
        }

        public async Task<int> CreateAsync(PersonApiModel personApiModel, CancellationToken cancellationToken)
        {
            int id;
            using var context = _applicationContext;

            var person = new Person
            {
                Phone = personApiModel.Phone,
                Email = personApiModel.Email,
                FullName = personApiModel.FullName,
                City = personApiModel.City
            };

            context.Persons.Add(person);
            await context.SaveChangesAsync(cancellationToken);

            id = person.Id;

            return id;
        }
    }
}
