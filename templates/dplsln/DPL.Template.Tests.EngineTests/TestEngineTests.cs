﻿using DPL.Template.Accessors;
using DPL.Template.Engines;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DPL.Template.Tests.EngineTests
{
    [TestClass]
    public class TestEngineTests : EngineTestBase
    {
        private readonly Mock<ITestAccessor> _testAccessorMock = new Mock<ITestAccessor>(MockBehavior.Strict);

        [TestInitialize]
        public override void TestInitialize()
        {

        }

        [TestMethod]
        public void TestMe_Success()
        {
            // ARRANGE 
            _testAccessorMock.Setup(x => x.TestMe(It.IsAny<string>())).Returns("hello");
            var engine = new TestEngine(_testAccessorMock.Object);

            // ACT
            var response = engine.TestMe("test test");

            // ASSERT
            Assert.AreEqual(response, "hello");
        }
    }
}
