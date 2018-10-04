using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using $ext_projectname$.Engines;

namespace $safeprojectname$
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Engine Tests")]
        public void DTOMapper_IsDTOMApperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
