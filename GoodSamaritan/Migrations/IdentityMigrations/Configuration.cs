namespace GoodSamaritan.Migrations.IdentityMigrations
{
    using GoodSamaritan.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodSamaritan.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\IdentityMigrations";
        }

        protected override void Seed(GoodSamaritan.Models.ApplicationDbContext context)
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

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Administrator"))
            {
                roleManager.Create(new IdentityRole("Administrator"));
            }

            if (!roleManager.RoleExists("Worker"))
            {
                roleManager.Create(new IdentityRole("Worker"));
            }

            if (!roleManager.RoleExists("Report"))
            {
                roleManager.Create(new IdentityRole("Report"));
            }

           /* var passwordHash = new PasswordHasher();
            

                var adminRole = new IdentityRole { Name = "Administrator", Id = Guid.NewGuid().ToString() };
                context.Roles.Add(adminRole);

                var workerRole = new IdentityRole { Name = "Worker", Id = Guid.NewGuid().ToString() };
                context.Roles.Add(workerRole);

                var reportRole = new IdentityRole { Name = "Report", Id = Guid.NewGuid().ToString() };
                context.Roles.Add(reportRole);

                var adam = new ApplicationUser { Email = "adam@gs.ca", Id = Guid.NewGuid().ToString(), UserName = "adam" , PasswordHash = passwordHash.HashPassword("P@$$w0rd") };
                adam.Roles.Add(new IdentityUserRole { RoleId = adminRole.Id, UserId = adam.Id });
                context.Users.Add(adam);

                var wendy = new ApplicationUser { Email = "wendy@gs.ca", Id = Guid.NewGuid().ToString(), UserName = "wendy", PasswordHash = passwordHash.HashPassword("P@$$w0rd") };
                wendy.Roles.Add(new IdentityUserRole { RoleId = workerRole.Id, UserId = wendy.Id });
                context.Users.Add(wendy);

                var rob = new ApplicationUser { Email = "rob@gs.ca", Id = Guid.NewGuid().ToString(), UserName = "rob", PasswordHash = passwordHash.HashPassword("P@$$w0rd") };
                rob.Roles.Add(new IdentityUserRole { RoleId = reportRole.Id, UserId = rob.Id });
                context.Users.Add(rob);


                context.SaveChanges();*/
            
            var adam = new ApplicationUser() { UserName = "adam@gs.ca"};
            var user = userManager.Create(adam, "P@$$w0rd");
            userManager.AddToRole(adam.Id, "Administrator");

            var wendy = new ApplicationUser() { UserName = "wendy@gs.ca"};
            var user2 = userManager.Create(wendy, "P@$$w0rd");
            userManager.AddToRole(wendy.Id, "Worker");

            var rob = new ApplicationUser() { UserName = "rob@gs.ca" };
            var user3 = userManager.Create(rob, "P@$$w0rd");
            userManager.AddToRole(rob.Id, "Report");
        }
    }
}
