using Microsoft.VisualStudio.TestTools.UnitTesting;
using $ext_projectname$.Accessors;

namespace $safeprojectname$
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Accessor Tests")]
        public void DTOMapper_IsDTOMapperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
