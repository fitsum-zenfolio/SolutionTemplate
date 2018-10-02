using Microsoft.Extensions.Configuration;
using $ext_projectname$.Common.Shared;
using $ext_projectname$.Utilities;

namespace $safeprojectname$
{
    abstract class AccessorBase : ServiceContractBase
    {
        public UtilityFactory UtilityFactory { get; set; }

        protected string DatabaseConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .AddEnvironmentVariables();
                var configuration = builder.Build();

                var db = configuration["REPLACE_WITH_CONNECTIONSTRING"];
                return db;
            }
        }

    }
}
