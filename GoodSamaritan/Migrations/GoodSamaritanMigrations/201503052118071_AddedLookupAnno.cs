namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLookupAnno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AbuserRelationshipModels", "AbuserRelationship", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.AgeModels", "Age", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.AssignedWorkerModels", "AssignedWorker", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.CrisisModels", "Crisis", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.DuplicateFileModels", "DuplicateFile", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EthnicityModels", "Ethnicity", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.FamilyViolenceModels", "FamilyViolenceFile", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.FiscalYearModels", "FiscalYear", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.IncidentModels", "Incident", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ProgramModels", "Program", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ReferralContactModels", "ReferralContact", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ReferralSourceModels", "ReferralSource", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.RepeatClientModels", "RepeatClient", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.RiskLevelModels", "RiskLevel", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.RiskStatusModels", "RiskStatus", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ServiceModels", "Service", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.BadDateReportModels", "BadDateReport", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.CityOfAssaultModels", "CityOfAssault", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.CityOfResidenceModels", "CityOfResidence", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.DrugFacilitatedAssaultModels", "DrugFacilitatedAssault", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EvidenceStoredModels", "EvidenceStored", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.HIVMedsModels", "HIVMeds", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.HospitalAttendedModels", "HospitalAttended", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.MedicalOnlyModels", "MedicalOnly", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.MultiplePerpetratorsModels", "MultiplePerpetrators", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.PoliceAttendanceModels", "PolicAttendance", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.PoliceReportedModels", "PolicReported", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ReferralHospitalModels", "ReferralHospital", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ReferredCBVSModels", "ReferredCBVS", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.SocialWorkAttendanceModels", "SocialWorkAttendance", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ThirdPartyReportModels", "ThirdPartyReport", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.VictimServicesModels", "VictimServices", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Work_ExploitationModel", "SexWorkExploitation", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.StatusOfFileModels", "StatusOfFile", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.VictimOfIncidentModels", "VictimOfIncident", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VictimOfIncidentModels", "VictimOfIncident", c => c.String());
            AlterColumn("dbo.StatusOfFileModels", "StatusOfFile", c => c.String());
            AlterColumn("dbo.Work_ExploitationModel", "SexWorkExploitation", c => c.String());
            AlterColumn("dbo.VictimServicesModels", "VictimServices", c => c.String());
            AlterColumn("dbo.ThirdPartyReportModels", "ThirdPartyReport", c => c.String());
            AlterColumn("dbo.SocialWorkAttendanceModels", "SocialWorkAttendance", c => c.String());
            AlterColumn("dbo.ReferredCBVSModels", "ReferredCBVS", c => c.String());
            AlterColumn("dbo.ReferralHospitalModels", "ReferralHospital", c => c.String());
            AlterColumn("dbo.PoliceReportedModels", "PolicReported", c => c.String());
            AlterColumn("dbo.PoliceAttendanceModels", "PolicAttendance", c => c.String());
            AlterColumn("dbo.MultiplePerpetratorsModels", "MultiplePerpetrators", c => c.String());
            AlterColumn("dbo.MedicalOnlyModels", "MedicalOnly", c => c.String());
            AlterColumn("dbo.HospitalAttendedModels", "HospitalAttended", c => c.String());
            AlterColumn("dbo.HIVMedsModels", "HIVMeds", c => c.String());
            AlterColumn("dbo.EvidenceStoredModels", "EvidenceStored", c => c.String());
            AlterColumn("dbo.DrugFacilitatedAssaultModels", "DrugFacilitatedAssault", c => c.String());
            AlterColumn("dbo.CityOfResidenceModels", "CityOfResidence", c => c.String());
            AlterColumn("dbo.CityOfAssaultModels", "CityOfAssault", c => c.String());
            AlterColumn("dbo.BadDateReportModels", "BadDateReport", c => c.String());
            AlterColumn("dbo.ServiceModels", "Service", c => c.String());
            AlterColumn("dbo.RiskStatusModels", "RiskStatus", c => c.String());
            AlterColumn("dbo.RiskLevelModels", "RiskLevel", c => c.String());
            AlterColumn("dbo.RepeatClientModels", "RepeatClient", c => c.String());
            AlterColumn("dbo.ReferralSourceModels", "ReferralSource", c => c.String());
            AlterColumn("dbo.ReferralContactModels", "ReferralContact", c => c.String());
            AlterColumn("dbo.ProgramModels", "Program", c => c.String());
            AlterColumn("dbo.IncidentModels", "Incident", c => c.String());
            AlterColumn("dbo.FiscalYearModels", "FiscalYear", c => c.String());
            AlterColumn("dbo.FamilyViolenceModels", "FamilyViolenceFile", c => c.String());
            AlterColumn("dbo.EthnicityModels", "Ethnicity", c => c.String());
            AlterColumn("dbo.DuplicateFileModels", "DuplicateFile", c => c.String());
            AlterColumn("dbo.CrisisModels", "Crisis", c => c.String());
            AlterColumn("dbo.AssignedWorkerModels", "AssignedWorker", c => c.String());
            AlterColumn("dbo.AgeModels", "Age", c => c.String());
            AlterColumn("dbo.AbuserRelationshipModels", "AbuserRelationship", c => c.String());
        }
    }
}
