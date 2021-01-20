using DPL.Template.Engines;
using DPL.Template.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DPL.Template.Tests.ManagerTests
{
    [TestClass]
    public class TestManagerTests : ManagerTestBase
    {
        private readonly Mock<ITestEngine> testEngineMock = new Mock<ITestEngine>(MockBehavior.Strict);

        [TestInitialize]
        public override void TestInitialize()
        {

        }

        [TestMethod]
        public void TestManagerMethod_Success()
        {
            // ARRANGE 
            testEngineMock.Setup(x => x.TestEngineMethod()).Returns(true);
            var manager = new TestManager(testEngineMock.Object);

            // ACT 
            var response = manager.TestManagerMethod();

            // ASSERT 
            Assert.IsTrue(response);
        }
    }
}
