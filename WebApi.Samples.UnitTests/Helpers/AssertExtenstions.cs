using System.Linq;
using FluentValidation.Results;
using NUnit.Framework;

namespace WebApi.Samples.UnitTests.Helpers
{
    public static class AssertExtenstions
    {
        public static void AssertContains(this ValidationResult validationResult, string errorMessage)
        {
            var errors = validationResult.Errors.Select(x => x.ErrorMessage);
            CollectionAssert.Contains(errors, errorMessage);
        }
    }
}
