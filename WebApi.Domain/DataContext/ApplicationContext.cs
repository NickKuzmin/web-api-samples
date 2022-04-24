using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Entities;

namespace WebApi.Domain.DataContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }

        public DbSet<City> Cities { get; set; }

        public DbSet<Person> Persons { get; set; }
    }
}