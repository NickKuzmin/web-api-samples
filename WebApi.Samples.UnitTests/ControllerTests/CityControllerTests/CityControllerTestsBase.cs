using Moq;
using NUnit.Framework;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Samples.UnitTests.ControllerTests.CityControllerTests
{
    [TestFixture]
    public abstract class PersonControllerTestsBase
    {
        public Mock<ICityDataProvider> CityDataProviderMock { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            CityDataProviderMock = new Mock<ICityDataProvider>();
        }
    }
}
