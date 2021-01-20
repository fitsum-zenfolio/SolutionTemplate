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
            return _testAccessor.TestMe(input);
        }
    }
}
