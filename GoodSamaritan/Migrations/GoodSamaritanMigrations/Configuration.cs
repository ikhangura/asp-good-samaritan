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

            context.FiscalYearModel.AddOrUpdate(
                fym => fym.FiscalYear,
                new FiscalYearModel { FiscalYear = "10-11" },
                new FiscalYearModel { FiscalYear = "11-12" },
                new FiscalYearModel { FiscalYear = "12-13" },
                new FiscalYearModel { FiscalYear = "13-14" },
                new FiscalYearModel { FiscalYear = "14-15" },
                new FiscalYearModel { FiscalYear = "15-16" },
                new FiscalYearModel { FiscalYear = "16-17" }
            );

            context.RiskLevelModel.AddOrUpdate(
                rlm => rlm.RiskLevel,
                new RiskLevelModel { RiskLevel = "High" },
                new RiskLevelModel { RiskLevel = "DVU" },
                new RiskLevelModel { RiskLevel = "null" }
            );

            context.CrisisModel.AddOrUpdate(
                cm => cm.Crisis,
                new CrisisModel { Crisis = "Call" },
                new CrisisModel { Crisis = "Accompaniment" },
                new CrisisModel { Crisis = "Drop-In" }
            );

            context.ServiceModel.AddOrUpdate(
                sm => sm.Service,
                new ServiceModel { Service = "File" },
                new ServiceModel { Service = "N/A" }
            );

            context.ProgramModel.AddOrUpdate(
                pm => pm.Program,
                new ProgramModel { Program = "Crisis" },
                new ProgramModel { Program = "Court" },
                new ProgramModel { Program = "SMART" },
                new ProgramModel { Program = "DVU" },
                new ProgramModel { Program = "MCFD" }
            );

            context.RiskStatusModel.AddOrUpdate(
                rsm => rsm.RiskStatus,
                new RiskStatusModel { RiskStatus = "Pending" },
                new RiskStatusModel { RiskStatus = "Complete" },
                new RiskStatusModel { RiskStatus = "null" }
            );

            context.AssignedWorkerModel.AddOrUpdate(
                awm => awm.AssignedWorker,
                new AssignedWorkerModel { AssignedWorker = "Michelle" },
                new AssignedWorkerModel { AssignedWorker = "Tyra" },
                new AssignedWorkerModel { AssignedWorker = "Louise" },
                new AssignedWorkerModel { AssignedWorker = "Angela" },
                new AssignedWorkerModel { AssignedWorker = "Dave" },
                new AssignedWorkerModel { AssignedWorker = "Troy" },
                new AssignedWorkerModel { AssignedWorker = "Michael" },
                new AssignedWorkerModel { AssignedWorker = "Manpreet" },
                new AssignedWorkerModel { AssignedWorker = "Patrick" },
                new AssignedWorkerModel { AssignedWorker = "None" }
            );



        }
    }
}
