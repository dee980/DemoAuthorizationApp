namespace WebApplication120.Migrations
{
    using Authorization_Module_DAL.Contexts;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Authorization_Module_DAL.Contexts.AuthorizationModuleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Authorization_Module_DAL.Contexts.AuthorizationModuleDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            SeedIntlizer.SeedInitlize(context);
            base.Seed(context);
        }
    }
}
