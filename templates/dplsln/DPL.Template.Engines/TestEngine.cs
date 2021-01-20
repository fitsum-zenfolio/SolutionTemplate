using DPL.Template.Accessors;
using System;
namespace DPL.Template.Engines
{
    public class TestEngine : ITestEngine
    {
        private readonly ITestAccessor _testAccessor;

        public TestEngine(ITestAccessor testAccessor)
        {
            _testAccessor = testAccessor;
        }

        public string TestMe(string input)
        {
            throw new NotImplementedException();
        }

        public bool TestEngineMethod()
        {
            return _testAccessor.TestAccessorMethod();
        }
    }
}
