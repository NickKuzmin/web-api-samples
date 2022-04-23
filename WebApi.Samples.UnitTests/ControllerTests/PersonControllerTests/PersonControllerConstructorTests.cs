using System;
using NUnit.Framework;
using WebApi.Domain.Services.Interfaces;
using WebApi.Samples.Controllers;

namespace WebApi.Samples.UnitTests.ControllerTests.PersonControllerTests
{
    public class PersonControllerConstructorTests : PersonControllerTestsBase
    {
        private IPersonDataProvider _personDataProvider;

        [Test]
        public void Constructor_PersonDataProviderIsNull_ExpectArgumentNullException()
        {
            // Arrange
            _personDataProvider = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Act());
        }

        [Test]
        public void Constructor_UnderValidConditions_ExpectSuccessAndNoExceptions()
        {
            // Act
            var result = Act();

            // Assert
            Assert.IsNotNull(result);
        }

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            _personDataProvider = PersonDataProviderMock.Object;
        }

        public PersonController Act()
        {
            return new PersonController(_personDataProvider);
        }
    }
}
