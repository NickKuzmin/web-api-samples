using Moq;
using NUnit.Framework;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Samples.UnitTests.ControllerTests.PersonControllerTests
{
    [TestFixture]
    public abstract class PersonControllerTestsBase
    {
        public Mock<IPersonDataProvider> PersonDataProviderMock { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            PersonDataProviderMock = new Mock<IPersonDataProvider>();
        }
    }
}
