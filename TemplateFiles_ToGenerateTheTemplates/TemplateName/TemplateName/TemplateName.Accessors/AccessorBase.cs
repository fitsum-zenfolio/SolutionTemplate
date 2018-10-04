using Microsoft.Extensions.Configuration;
using $ext_projectname$.Common.Shared;
using $ext_projectname$.Utilities;

namespace TemplateName.Accessors
{
    abstract class AccessorBase : ServiceContractBase
    {
        public UtilityFactory UtilityFactory { get; set; }
    }
}
