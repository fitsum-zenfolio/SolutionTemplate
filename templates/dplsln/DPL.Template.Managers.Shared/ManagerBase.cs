using DPL.Template.Accessors;
using DPL.Template.Common.Shared;
using DPL.Template.Engines;
using DPL.Template.Utilities;

namespace DPL.Template.Managers.Shared
{
    public abstract class ManagerBase : ServiceContractBase
    {
        public EngineFactory EngineFactory { get; set; }
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        protected ManagerBase()
        {

        }
    }
}
