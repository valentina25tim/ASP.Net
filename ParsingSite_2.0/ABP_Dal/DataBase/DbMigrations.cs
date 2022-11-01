using System;
using DbUp;
using Microsoft.Extensions.Configuration;

namespace ABP_Dal.DataBase
{
    public class DbMigrations
    {
        public DbMigrations(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices()
        {
            var connectionString = Configuration.GetConnectionString("data source=LAPTOP-MFD4FGN1\\SQLEXPRESS07;initial catalog=QandA;trusted_connection=true");


            //We've told DbUp where the database is and to look for SQL Scripts that have 
            //been embedded in our project. We've also told DbUp to do the database migrations 
            //in a transaction.

            EnsureDatabase.For.SqlDatabase(connectionString);
            var upgrader = DeployChanges.To
                .SqlDatabase(connectionString, null)
                .WithScriptsEmbeddedInAssembly
                (System.Reflection.Assembly.GetExecutingAssembly())
                    .WithTransaction()
                    .Build();


            //We are using the IsUpgradeRequired method in the DbUp upgrade to check whether
            //there are any pending SQL Scripts, and using the PerformUpgrade method to do
            // the actual migration.

            if (upgrader.IsUpgradeRequired())
            {
                upgrader.PerformUpgrade();
            }

        }
    }
}
