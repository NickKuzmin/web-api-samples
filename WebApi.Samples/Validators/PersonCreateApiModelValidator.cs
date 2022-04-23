using FluentValidation;
using WebApi.Domain.ApiModels;

namespace WebApi.Samples.Validators
{
    public class PersonCreateApiModelValidator : AbstractValidator<PersonCreateApiModel>
    {
        public PersonCreateApiModelValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Please, specify full name")
                .Matches(@"^[А-Яа-яЁ-ё ]*$").WithMessage("Only cyrillic characters are allowed.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Please, specify phone")
                .Matches(@"^(\+7)(\(\d{3}\))\d{3} \d{2} \d{2}$").WithMessage("Only format '+7(xxx)xxx xx xx' is allowed.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please, specify email")
                .EmailAddress().WithMessage("Only email format is allowed.");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Please, specify city");
        }
    }
}
