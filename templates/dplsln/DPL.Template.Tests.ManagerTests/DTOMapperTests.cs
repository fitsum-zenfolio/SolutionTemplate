using Microsoft.VisualStudio.TestTools.UnitTesting;
using DPL.Template.Managers.Shared;

namespace DPL.Template.Tests.ManagerTests
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Manager Tests")]
        public void DTOMapper_IsDTOMApperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
