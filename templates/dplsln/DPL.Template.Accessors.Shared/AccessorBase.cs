using Microsoft.Extensions.Configuration;
using DPL.Template.Common.Shared;
using DPL.Template.Utilities;

namespace DPL.Template.Accessors.Shared
{
    public abstract class AccessorBase : ServiceContractBase
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
