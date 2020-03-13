using Microsoft.VisualStudio.TestTools.UnitTesting;
using DPL.Template.Accessors.Shared.EntityFramework;
using DPL.Template.Common.Contracts;

namespace DPL.Template.Tests.AccessorTests
{
    [TestClass]
    public abstract class TestAccessorBase
    {
        public TestAccessorBase()
        {
        }

        [TestInitialize()]
        public void Init()
        {
            CreateGlobalContext();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            CancelGlobalTransaction();
        }

        public static void CreateGlobalContext()
        {
            DatabaseContext.UnitTestContext = DatabaseContext.Create(false);
            DatabaseContext.UnitTestContext.Database.BeginTransaction();
        }

        public static void CancelGlobalTransaction()
        {
            if (DatabaseContext.UnitTestContext != null)
            {
                DatabaseContext.UnitTestContext.Database.RollbackTransaction();
                DatabaseContext.UnitTestContext.AllowDispose = true;
                DatabaseContext.UnitTestContext.Dispose();
                DatabaseContext.UnitTestContext = null;
            }
        }

        protected AmbientContext Context { get; } = new AmbientContext();
    }
}
