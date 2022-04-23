using MediatR;
using Moq;
using NUnit.Framework;

namespace WebApi.Samples.UnitTests.ControllerTests.PersonControllerTests
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
