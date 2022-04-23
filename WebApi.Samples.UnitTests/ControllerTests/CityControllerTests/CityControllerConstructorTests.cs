using System;
using MediatR;
using NUnit.Framework;
using WebApi.Samples.Controllers;

namespace WebApi.Samples.UnitTests.ControllerTests.CityControllerTests
{
    public class CityControllerConstructorTests : PersonControllerTestsBase
    {
        private IMediator _mediator;

        [Test]
        public void Constructor_CityDataProviderIsNull_ExpectArgumentNullException()
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

        public CityController Act()
        {
            return new CityController(_mediator);
        }
    }
}
