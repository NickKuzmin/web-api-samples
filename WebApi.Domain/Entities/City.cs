using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Entities
{
    public class City
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
