using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using WebApi.Domain.ApiModels;

namespace WebApi.Samples.Validators
{
    public class PersonCreateApiModelValidator : AbstractValidator<PersonCreateApiModel>
    {
        public PersonCreateApiModelValidator()
        {
            RuleFor(x => x.Phone)
                .NotEmpty()
                    .WithMessage("Please specify phone");
            RuleFor(x => x.Email)
                .NotEmpty()
                    .WithMessage("Please specify email");
            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("Please specify city");
        }
    }
}
