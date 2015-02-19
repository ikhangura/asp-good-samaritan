namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GoodSamaritan.Models;
    using GoodSamaritan.Models.LookupTables;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

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

        /* -- Start SMART Table Seeding -- */

            context.Work_ExploitationModel.AddOrUpdate(
                swem => swem.SexWorkExploitation,
                new Work_ExploitationModel { SexWorkExploitation = "Yes" },
                new Work_ExploitationModel { SexWorkExploitation = "No" },
                new Work_ExploitationModel { SexWorkExploitation = "N/A" }
            );

            context.MultiplePerpetratorsModel.AddOrUpdate(
                mpm => mpm.MultiplePerpetrators,
                new MultiplePerpetratorsModel { MultiplePerpetrators = "Yes" },
                new MultiplePerpetratorsModel { MultiplePerpetrators = "No" },
                new MultiplePerpetratorsModel { MultiplePerpetrators = "N/A" }
            );

            context.DrugFacilitatedAssaultModel.AddOrUpdate(
                dfam => dfam.DrugFacilitatedAssault,
                new DrugFacilitatedAssaultModel { DrugFacilitatedAssault = "Yes" },
                new DrugFacilitatedAssaultModel { DrugFacilitatedAssault = "No" },
                new DrugFacilitatedAssaultModel { DrugFacilitatedAssault = "N/A" }
            );

            context.CityOfAssaultModel.AddOrUpdate(
                coam => coam.CityOfAssault,
                new CityOfAssaultModel { CityOfAssault = "Surrey" },
                new CityOfAssaultModel { CityOfAssault = "Abbotsford" },
                new CityOfAssaultModel { CityOfAssault = "Agassiz" },
                new CityOfAssaultModel { CityOfAssault = "BostonBar" },
                new CityOfAssaultModel { CityOfAssault = "Burnaby" },
                new CityOfAssaultModel { CityOfAssault = "Chilliwack" },
                new CityOfAssaultModel { CityOfAssault = "Coquitlam" },
                new CityOfAssaultModel { CityOfAssault = "Delta" },
                new CityOfAssaultModel { CityOfAssault = "Harrison Hot Springs" },
                new CityOfAssaultModel { CityOfAssault = "Hope" },
                new CityOfAssaultModel { CityOfAssault = "Langley" },
                new CityOfAssaultModel { CityOfAssault = "Maple Ridge" },
                new CityOfAssaultModel { CityOfAssault = "Mission" },
                new CityOfAssaultModel { CityOfAssault = "New Westminster" },
                new CityOfAssaultModel { CityOfAssault = "Pitt Meadows" },
                new CityOfAssaultModel { CityOfAssault = "Port Coquitlam" },
                new CityOfAssaultModel { CityOfAssault = "Port Moody" },
                new CityOfAssaultModel { CityOfAssault = "Vancouver" },
                new CityOfAssaultModel { CityOfAssault = "White Rock" },
                new CityOfAssaultModel { CityOfAssault = "Yale" },
                new CityOfAssaultModel { CityOfAssault = "Other-BC" },
                new CityOfAssaultModel { CityOfAssault = "Out-Of-Province" },
                new CityOfAssaultModel { CityOfAssault = "International" }
            );

            context.CityOfResidenceModel.AddOrUpdate(
                corm => corm.CityOfResidence,
                new CityOfResidenceModel { CityOfResidence = "Surrey" },
                new CityOfResidenceModel { CityOfResidence = "Abbotsford" },
                new CityOfResidenceModel { CityOfResidence = "Aggasiz" },
                new CityOfResidenceModel { CityOfResidence = "Boston Bar" },
                new CityOfResidenceModel { CityOfResidence = "Burnaby" },
                new CityOfResidenceModel { CityOfResidence = "Chilliwack" },
                new CityOfResidenceModel { CityOfResidence = "Coquitlam" },
                new CityOfResidenceModel { CityOfResidence = "Delta" },
                new CityOfResidenceModel { CityOfResidence = "Harrison Hot Springs" },
                new CityOfResidenceModel { CityOfResidence = "Hope" },
                new CityOfResidenceModel { CityOfResidence = "Langley" },
                new CityOfResidenceModel { CityOfResidence = "Maple Ridge" },
                new CityOfResidenceModel { CityOfResidence = "Mission" },
                new CityOfResidenceModel { CityOfResidence = "New Westminster" },
                new CityOfResidenceModel { CityOfResidence = "Pitt Meadows" },
                new CityOfResidenceModel { CityOfResidence = "Port Coquitlam" },
                new CityOfResidenceModel { CityOfResidence = "Port Moody" },
                new CityOfResidenceModel { CityOfResidence = "Vancouver" },
                new CityOfResidenceModel { CityOfResidence = "White Rock" },
                new CityOfResidenceModel { CityOfResidence = "Yale" },
                new CityOfResidenceModel { CityOfResidence = "Other-BC" },
                new CityOfResidenceModel { CityOfResidence = "Out-Of-Province" },
                new CityOfResidenceModel { CityOfResidence = "International" }
           );

            context.ReferralHospitalModel.AddOrUpdate(
                rhm => rhm.ReferralHospital,
                new ReferralHospitalModel { ReferralHospital = "Abbotsford Regional Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Surrey Memorial Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Burnaby Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Chilliwack General Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Delta Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Eagle Ridge Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Fraser Canyon Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Langley Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Mission Hospital" },
                new ReferralHospitalModel { ReferralHospital = "PeaceArch Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Ridge Meadows Hospital" },
                new ReferralHospitalModel { ReferralHospital = "Royal Columbia Hospital" }
            );

            context.HospitalAttendedModel.AddOrUpdate(
                ham => ham.HospitalAttended,
                new HospitalAttendedModel { HospitalAttended = "Abbotsford Regional Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Surrey Memorial Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Burnaby Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Chilliwack General Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Delta Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Eagle Ridge Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Fraser Canyon Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Langley Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Mission Hospital" },
                new HospitalAttendedModel { HospitalAttended = "PeaceArch Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Ridge Meadows Hospital" },
                new HospitalAttendedModel { HospitalAttended = "Royal Columbia Hospital" }
            );

            context.SocialWorkAttendanceModel.AddOrUpdate(
                swam => swam.SocialWorkAttendance,
                new SocialWorkAttendanceModel { SocialWorkAttendance = "Yes" },
                new SocialWorkAttendanceModel { SocialWorkAttendance = "No" },
                new SocialWorkAttendanceModel { SocialWorkAttendance = "N/A" }
            );

            context.PoliceAttendanceModel.AddOrUpdate(
                pam => pam.PolicAttendance,
                new PoliceAttendanceModel { PolicAttendance = "Yes" },
                new PoliceAttendanceModel { PolicAttendance = "No" },
                new PoliceAttendanceModel { PolicAttendance = "N/A" }
            );

            context.VictimServicesModel.AddOrUpdate(
                vsm => vsm.VictimServices,
                new VictimServicesModel { VictimServices = "Yes" },
                new VictimServicesModel { VictimServices = "No" },
                new VictimServicesModel { VictimServices = "N/A" }
            );

            context.MedicalOnlyModel.AddOrUpdate(
                mom => mom.MedicalOnly,
                new MedicalOnlyModel { MedicalOnly = "Yes" },
                new MedicalOnlyModel { MedicalOnly = "No" },
                new MedicalOnlyModel { MedicalOnly = "N/A" }
            );

            context.EvidenceStoredModel.AddOrUpdate(
                esm => esm.EvidenceStored,
                new EvidenceStoredModel { EvidenceStored = "Yes" },
                new EvidenceStoredModel { EvidenceStored = "No" },
                new EvidenceStoredModel { EvidenceStored = "N/A" }
            );

            context.HIVMedsModel.AddOrUpdate(
                hivmm => hivmm.HIVMeds,
                new HIVMedsModel { HIVMeds = "Yes" },
                new HIVMedsModel { HIVMeds = "No" },
                new HIVMedsModel { HIVMeds = "N/A" }
            );

            context.ReferredCBVSModel.AddOrUpdate(
                rcbvsm => rcbvsm.ReferredCBVS,
                new ReferredCBVSModel { ReferredCBVS = "Yes" },
                new ReferredCBVSModel { ReferredCBVS = "No" },
                new ReferredCBVSModel { ReferredCBVS = "PVBS Only"},
                new ReferredCBVSModel { ReferredCBVS = "N/A" }
            );

            context.PoliceReportedModel.AddOrUpdate(
                prm => prm.PolicReported,
                new PoliceReportedModel { PolicReported = "Yes" },
                new PoliceReportedModel { PolicReported = "No" },
                new PoliceReportedModel { PolicReported = "N/A" }
            );

            context.ThirdPartyReportModel.AddOrUpdate(
                tprm => tprm.ThirdPartyReport,
                new ThirdPartyReportModel { ThirdPartyReport = "Yes" },
                new ThirdPartyReportModel { ThirdPartyReport = "No" },
                new ThirdPartyReportModel { ThirdPartyReport = "N/A" }
            );

            context.BadDateReportModel.AddOrUpdate(
                bdrm => bdrm.BadDateReport,
                new BadDateReportModel { BadDateReport = "Yes" },
                new BadDateReportModel { BadDateReport = "No" },
                new BadDateReportModel { BadDateReport = "N/A" }
            );


        
        
        }
    }
}
