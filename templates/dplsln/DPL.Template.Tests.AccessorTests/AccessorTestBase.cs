using Microsoft.VisualStudio.TestTools.UnitTesting;
using DPL.Template.Common.Contracts;
using System.Transactions;

namespace DPL.Template.Tests.AccessorTests
{
    [TestClass]
    public abstract class AccessorTestBase
    {
        private TransactionScope _transactionScopeFixture;

        public AccessorTestBase()
        {
        }

        [TestInitialize]
        public void BaseTestInitialize()
        {
            var transactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TransactionManager.MaximumTimeout
            };
            _transactionScopeFixture = new TransactionScope(
                TransactionScopeOption.Required,
                transactionOptions);
        }
        [TestCleanup]
        public void BaseTestCleanup()
        {
            _transactionScopeFixture.Dispose();
        }

        protected AmbientContext Context { get; } = new AmbientContext();
    }
}
