using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace TemplateName.Accessors.EntityFramework
{
    internal class DatabaseContext : DbContext
    {
        internal static DatabaseContext UnitTestContext { get; set; }

        // Everyone that uses the DatabaseContext will use this 
        // constructor method
        internal static DatabaseContext Create(bool allowDispose = true)
        {
            if (UnitTestContext == null)
                return new DatabaseContext()
                {
                    AllowDispose = allowDispose
                };
            return UnitTestContext;
        }

        private DatabaseContext()
            : base()

        {

        }

        public override void Dispose()
        {
            // this is the secret of the wrapper, without this do nothing we won't handle rolling back transactions
            // only dispose if we are allowing it to dispose
            if (AllowDispose)
                base.Dispose();
        }

        protected IConfigurationRoot Configuration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            base.OnConfiguring(optionsBuilder);

            string connectionString = Common.Shared.Config.SqlServerConnectionString;
            if (!string.IsNullOrEmpty(connectionString))
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            else
            {
                connectionString = Common.Shared.Config.SqliteConnectionString;

                if (string.IsNullOrEmpty(connectionString))
                    throw new InvalidOperationException("Connection string environment variable missing.");

                optionsBuilder.UseSqlite(connectionString);
            }
        }

        //public virtual DbSet<CartItem> CartItems { get; set; }

        public bool AllowDispose { get; set; } = true;

    }
}