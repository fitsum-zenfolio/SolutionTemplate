using Microsoft.VisualStudio.TestTools.UnitTesting;
using DPL.Template.Accessors.Shared;

namespace DPL.Template.Tests.AccessorTests
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
