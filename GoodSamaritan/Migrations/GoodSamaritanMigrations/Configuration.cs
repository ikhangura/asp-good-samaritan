namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GoodSamaritan.Models;
    using GoodSamaritan.Models.LookupTables;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodSamaritan.Models.GoodSamaritanModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\GoodSamaritanMigrations";
        }

        protected override void Seed(GoodSamaritan.Models.GoodSamaritanModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.UserModel.AddOrUpdate(
                um => um.Email,
                new UserModel { Email = "adam@gs.ca", Password = "P@$$w0rd", Role = "Adminstrator" },
                new UserModel { Email = "wendy@gs.ca", Password = " P@$$w0rd", Role = "Worker" },
                new UserModel { Email = "rob@gs.ca", Password = "P@$$w0rd", Role = "Report" }
            );

        }
    }
}
