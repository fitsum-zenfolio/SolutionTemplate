using DPL.Template.Common;
using Microsoft.Extensions.Configuration;

namespace DPL.Template.Accessors
{
    public abstract class AccessorBase : ServiceContractBase
    {
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
