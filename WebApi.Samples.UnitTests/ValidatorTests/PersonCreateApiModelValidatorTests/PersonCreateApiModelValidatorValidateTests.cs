using AutoFixture;
using FluentValidation.Results;
using NUnit.Framework;
using WebApi.Domain.ApiModels;
using WebApi.Samples.UnitTests.Helpers;
using WebApi.Samples.Validators;

namespace WebApi.Samples.UnitTests.ValidatorTests.PersonCreateApiModelValidatorTests
{
    [TestFixture]
    public class PersonCreateApiModelValidatorValidateTests : TestBase
    {
        private PersonCreateApiModel _personCreateApiModel;

        [Test]
        [TestCase("KuzminNikita")]
        [TestCase("Кузьмин Никита.")]
        public void Validate_FullNameIsNotCyrillic_ExpectValidationResultIsFalse(string fullName)
        {
            // Assert
            _personCreateApiModel.FullName = fullName;

            // Act
            var result = Act();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsValid);
            Assert.IsNotNull(result.Errors);

            result.AssertContains("Only cyrillic characters are allowed.");
        }

        [Test]
        [TestCase("+8(123)456 78 90")]
        [TestCase("7(123)456 78 90")]
        [TestCase("+7(123)4567890")]
        public void Validate_PhoneHasIncorrectFormat_ExpectValidationResultIsFalse(string phone)
        {
            // Assert
            _personCreateApiModel.Phone = phone;

            // Act
            var result = Act();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsValid);

            result.AssertContains("Only format '+7(xxx)xxx xx xx' is allowed.");
        }

        [Test]
        [TestCase("kuzmin.nick@rambler.ru@ru")]
        [TestCase("kuzmin.nick@")]
        [TestCase("kuzmin.nick")]
        public void Validate_EmailHasIncorrectFormat_ExpectValidationResultIsFalse(string email)
        {
            // Assert
            _personCreateApiModel.Email = email;

            // Act
            var result = Act();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsValid);

            result.AssertContains("Only email format is allowed.");
        }

        [Test]
        public void Validate_UnderValidConditions_ExpectSuccessAndNoExceptions()
        {
            // Act
            var result = Act();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsValid);
        }

        [SetUp]
        public void SetUp()
        {
            _personCreateApiModel = Builder
                .Build<PersonCreateApiModel>()
                .With(x => x.Phone, "+7(123)456 78 90")
                .With(x => x.Email, "kuzmin.nick@rambler.ru")
                .With(x => x.FullName, "Кузьмин Никита")
                .With(x => x.City, "Ярославль")
                .Create();
        }

        public ValidationResult Act()
        {
            var personCreateApiModelValidator = new PersonCreateApiModelValidator();
            return personCreateApiModelValidator.Validate(_personCreateApiModel);
        }
    }
}
