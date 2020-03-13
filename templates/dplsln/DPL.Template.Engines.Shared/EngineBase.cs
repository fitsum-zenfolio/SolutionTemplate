using DPL.Template.Accessors;
using DPL.Template.Common.Shared;
using DPL.Template.Utilities;

namespace DPL.Template.Engines.Shared
{
    public abstract class EngineBase : ServiceContractBase
    {
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        protected EngineBase()
        {

        }
    }
}
