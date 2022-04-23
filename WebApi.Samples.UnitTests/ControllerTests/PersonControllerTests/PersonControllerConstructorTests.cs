using System;
using MediatR;
using NUnit.Framework;
using WebApi.Samples.Controllers;

namespace WebApi.Samples.UnitTests.ControllerTests.PersonControllerTests
{
    public class PersonControllerConstructorTests : PersonControllerTestsBase
    {
        private IMediator _mediator;

        [Test]
        public void Constructor_MediatorIsNull_ExpectArgumentNullException()
        {
            // Arrange
            _mediator = null;

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
            _mediator = MediatorMock.Object;
        }

        public PersonController Act()
        {
            return new PersonController(_mediator);
        }
    }
}
