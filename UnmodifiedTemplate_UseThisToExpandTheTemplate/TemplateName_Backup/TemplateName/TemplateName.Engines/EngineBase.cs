using TemplateName.Accessors;
using TemplateName.Common.Shared;
using TemplateName.Utilities;

namespace TemplateName.Engines
{
    abstract class EngineBase : ServiceContractBase
    {
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        protected EngineBase()
        {

        }
    }
}
