using Microsoft.Extensions.Configuration;
using $ext_projectname$.Common.Shared;
using $ext_projectname$.Utilities;

namespace $safeprojectname$
{
    abstract class AccessorBase : ServiceContractBase
    {
        public UtilityFactory UtilityFactory { get; set; }
    }
}
