using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DPL.Template.Accessors.EntityFramework
{
    public partial class DatabaseContext : DbContext
    {
        protected IConfigurationRoot Configuration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Common.Config.SqlServerConnectionString);
            }
        }
    }
}
