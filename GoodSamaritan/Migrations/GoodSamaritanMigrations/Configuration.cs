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

            context.ReferralSourceModel.AddOrUpdate(
                rsm => rsm.ReferralSource,
                new ReferralSourceModel { ReferralSource = "Community Agency" },
                new ReferralSourceModel { ReferralSource = "Family/Friend" },
                new ReferralSourceModel { ReferralSource = "Government" },
                new ReferralSourceModel { ReferralSource = "CVAP" },
                new ReferralSourceModel { ReferralSource = "CBVS" }
            );

            context.ReferralContactModel.AddOrUpdate(
                rcm => rcm.ReferralContact,
                new ReferralContactModel { ReferralContact = "PBVS" },
                new ReferralContactModel { ReferralContact = "MCFD" },
                new ReferralContactModel { ReferralContact = "VictimLINK" },
                new ReferralContactModel { ReferralContact = "TH" },
                new ReferralContactModel { ReferralContact = "Self" },
                new ReferralContactModel { ReferralContact = "FNS" },
                new ReferralContactModel { ReferralContact = "Other" },
                new ReferralContactModel { ReferralContact = "Medical" }
            );

            context.IncidentModel.AddOrUpdate(
                im => im.Incident,
                new IncidentModel { Incident = "Abduction" },
                new IncidentModel { Incident = "Adult Historical Secual Assault" },
                new IncidentModel { Incident = "Adult Sexual Assault" },
                new IncidentModel { Incident = "Partner Assault" },
                new IncidentModel { Incident = "Attempted Murder" },
                new IncidentModel { Incident = "Child Physical Assault" },
                new IncidentModel { Incident = "Child Sexual Abuse/Exploitation" },
                new IncidentModel { Incident = "Criminal Harrassment/Stalking" },
                new IncidentModel { Incident = "Elder Abuse" },
                new IncidentModel { Incident = "Human Trafficking" },
                new IncidentModel { Incident = "N/A" },
                new IncidentModel { Incident = "Other" },
                new IncidentModel { Incident = "Other Assault" },
                new IncidentModel { Incident = "Other Crime - DV" },
                new IncidentModel { Incident = "Other Familial Assault" },
                new IncidentModel { Incident = "Threatending" },
                new IncidentModel { Incident = "Youth Secual Assault/Exploitation" }
            );

            context.AbuserRelationshipModel.AddOrUpdate(
                arm => arm.AbuserRelationship,
                new AbuserRelationshipModel { AbuserRelationship = "Acquaintance" },
                new AbuserRelationshipModel { AbuserRelationship = "Bad Date" },
                new AbuserRelationshipModel { AbuserRelationship = "DNA" },
                new AbuserRelationshipModel { AbuserRelationship = "Ex-Partner" },
                new AbuserRelationshipModel { AbuserRelationship = "Friend" },
                new AbuserRelationshipModel { AbuserRelationship = "Multiple Perps" },
                new AbuserRelationshipModel { AbuserRelationship = "N/A" },
                new AbuserRelationshipModel { AbuserRelationship = "Other" },
                new AbuserRelationshipModel { AbuserRelationship = "Other Familial" },
                new AbuserRelationshipModel { AbuserRelationship = "Parent" },
                new AbuserRelationshipModel { AbuserRelationship = "Partner" },
                new AbuserRelationshipModel { AbuserRelationship = "Sibling" },
                new AbuserRelationshipModel { AbuserRelationship = "Stranger" }
            );

            context.VictimOfIncidentModel.AddOrUpdate(
                voim => voim.VictimOfIncident,
                new VictimOfIncidentModel { VictimOfIncident = "Primary" },
                new VictimOfIncidentModel { VictimOfIncident = "Secondary" }
            );

            context.FamilyViolenceModel.AddOrUpdate(
                fvm => fvm.FamilyViolenceFile,
                new FamilyViolenceModel { FamilyViolenceFile = "Yes" },
                new FamilyViolenceModel { FamilyViolenceFile = "No" },
                new FamilyViolenceModel { FamilyViolenceFile = "N/A" }
            );

            context.EthnicityModel.AddOrUpdate(
                em => em.Ethnicity,
                new EthnicityModel { Ethnicity = "Indigenous" },
                new EthnicityModel { Ethnicity = "Asian" },
                new EthnicityModel { Ethnicity = "Black" },
                new EthnicityModel { Ethnicity = "Caucasian" },
                new EthnicityModel { Ethnicity = "Declined" },
                new EthnicityModel { Ethnicity = "Latin" },
                new EthnicityModel { Ethnicity = "Middle Eastern" },
                new EthnicityModel { Ethnicity = "Other" },
                new EthnicityModel { Ethnicity = "South Asian" },
                new EthnicityModel { Ethnicity = "South Eash Asian" }
            );

            context.AgeModel.AddOrUpdate(
                am => am.Age,
                new AgeModel { Age = "Adult(>24<65)" },
                new AgeModel { Age = "Youth(>12<19)" },
                new AgeModel { Age = "Youth(>18<25)" },
                new AgeModel { Age = "Child(<13)" },
                new AgeModel { Age = "Senior(>64)" }
            );

            context.RepeatClientModel.AddOrUpdate(
                rcm => rcm.RepeatClient,
                new RepeatClientModel { RepeatClient = "Yes" },
                new RepeatClientModel { RepeatClient = "null" }
            );

            context.DuplicateFileModel.AddOrUpdate(
                dfm => dfm.DuplicateFile,
                new DuplicateFileModel { DuplicateFile = "Yes" },
                new DuplicateFileModel { DuplicateFile = "null" }
            );

            context.StatusOfFileModel.AddOrUpdate(
                sof => sof.StatusOfFile,
                new StatusOfFileModel { StatusOfFile = "Reopened" },
                new StatusOfFileModel { StatusOfFile = "Closed" },
                new StatusOfFileModel { StatusOfFile = "Open" }
            );

        }
    }
}
