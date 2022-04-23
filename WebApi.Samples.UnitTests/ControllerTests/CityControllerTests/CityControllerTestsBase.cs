using MediatR;
using Moq;
using NUnit.Framework;
using WebApi.Domain.Services.Interfaces;

namespace WebApi.Samples.UnitTests.ControllerTests.CityControllerTests
{
    [TestFixture]
    public abstract class PersonControllerTestsBase
    {
        public Mock<IMediator> MediatorMock { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            MediatorMock = new Mock<IMediator>();
        }
    }
}
