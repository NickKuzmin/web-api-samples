using AutoFixture;
using NUnit.Framework;

namespace WebApi.Samples.UnitTests
{
    [TestFixture]
    public abstract class TestBase
    {
        protected Fixture Builder = new();
    }
}
