using System;
using NUnit.Framework;
using WebApi.Domain.Services.Interfaces;
using WebApi.Samples.Controllers;

namespace WebApi.Samples.UnitTests.ControllerTests.CityControllerTests
{
    public class PersonControllerConstructorTests : PersonControllerTestsBase
    {
        private ICityDataProvider _cityDataProvider;

        [Test]
        public void Constructor_CityDataProviderIsNull_ExpectArgumentNullException()
        {
            // Arrange
            _cityDataProvider = null;

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
            _cityDataProvider = CityDataProviderMock.Object;
        }

        public CityController Act()
        {
            return new CityController(_cityDataProvider);
        }
    }
}
