﻿using DPL.Template.Engines;
using System;

namespace DPL.Template.Managers
{
    public class TestManager : ITestManager
    {
        private readonly ITestEngine _testEngine;

        public TestManager(ITestEngine testEngine)
        {
            _testEngine = testEngine;
        }

        public string TestMe(string input)
        {
            throw new NotImplementedException();
        }

        public bool TestManagerMethod()
        {
            return _testEngine.TestEngineMethod();
        }
    }
}