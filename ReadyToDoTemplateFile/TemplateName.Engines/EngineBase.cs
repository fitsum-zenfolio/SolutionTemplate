using $ext_projectname$.Accessors;
using $ext_projectname$.Common.Shared;
using $ext_projectname$.Utilities;

namespace $safeprojectname$
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
