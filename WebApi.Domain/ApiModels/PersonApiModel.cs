using System;

namespace WebApi.Domain.ApiModels
{
    public class PersonApiModel
    {
        public Guid Id { get; set; }
        
        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
    }
}
