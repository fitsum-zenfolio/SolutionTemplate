using $ext_projectname$.Accessors;
using $ext_projectname$.Common.Shared;
using $ext_projectname$.Engines;
using $ext_projectname$.Utilities;

namespace $safeprojectname$
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
