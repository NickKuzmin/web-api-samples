using System;

namespace WebApi.Samples.ApiModels
{
    public class PersonApiModel
    {
        public Guid Id { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
    }
}
