using DPL.Template.Engines;
using DPL.Template.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DPL.Template.Tests.ManagerTests
{
    [TestClass]
    public class TestManagerTests : ManagerTestBase
    {
        private readonly Mock<ITestEngine> _testEngineMock = new Mock<ITestEngine>(MockBehavior.Strict);

        [TestInitialize]
        public override void TestInitialize()
        {

        }

        [TestMethod]
        public void TestManagerMethod_Success()
        {
            // ARRANGE 
            _testEngineMock.Setup(x => x.TestMe(It.IsAny<string>())).Returns("hello");
            var manager = new TestManager(_testEngineMock.Object);

            // ACT 
            var response = manager.TestMe("test test");

            // ASSERT 
            Assert.AreEqual(response, "hello");
        }
    }
}
