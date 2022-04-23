using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Entities
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
    }
}
