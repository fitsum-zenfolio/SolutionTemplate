using DbUp;
using DbUp.Engine;
using System;
using System.Reflection;
using System.IO;
using Microsoft.Extensions.Configuration;
using $ext_projectname$.Common.Shared;

namespace TemplateName.DbUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = Config.SqlServerConnectionString;

            EnsureDatabase.For.SqlDatabase(connectionString);

            UpgradeEngine migrator = DeployChanges.To
                .SqlDatabase(connectionString)
                .WithTransaction()
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .WithExecutionTimeout(TimeSpan.FromSeconds(300))
                .LogToConsole()
                .Build();

            DatabaseUpgradeResult result = migrator.PerformUpgrade();


            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
                //if (Environment.UserInteractive)
                //    Console.ReadLine();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            //if (Environment.UserInteractive)
            //    Console.ReadLine();

            return;
        }
    }
}
