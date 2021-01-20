using DPL.Template.Accessors;
using DPL.Template.Engines;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DPL.Template.Tests.EngineTests
{
    [TestClass]
    public class TestEngineTests : EngineTestBase
    {
        private readonly Mock<ITestAccessor> testAccessorMock = new Mock<ITestAccessor>(MockBehavior.Strict);

        [TestInitialize]
        public override void TestInitialize()
        {

        }

        [TestMethod]
        public void TestEngineMethod_Success()
        {
            // ARRANGE 
            testAccessorMock.Setup(x => x.TestAccessorMethod()).Returns(true);
            var engine = new TestEngine(testAccessorMock.Object);

            // ACT
            var response = engine.TestEngineMethod();

            // ASSERT
            Assert.IsTrue(response);
        }
    }
}
