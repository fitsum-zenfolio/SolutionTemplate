using TemplateName.Accessors;
using TemplateName.Common.Shared;
using TemplateName.Engines;
using TemplateName.Utilities;

namespace TemplateName.Managers
{
    abstract class ManagerBase : ServiceContractBase
    {
        public EngineFactory EngineFactory { get; set; }
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        protected ManagerBase()
        {

        }
    }
}
