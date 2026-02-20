namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Concrate.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            TargetDatabase = new DbConnectionInfo(
                @"Data Source=ilhan\SQLEXPRESS;Initial Catalog=DbMvcProje;Integrated Security=True",
                "System.Data.SqlClient"
            );
        }

        protected override void Seed(DataAccessLayer.Concrate.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
