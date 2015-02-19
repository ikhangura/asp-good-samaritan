namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationshipModels",
                c => new
                    {
                        AbuserRelationship = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.AbuserRelationship);
            
            CreateTable(
                "dbo.ClientModels",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNumber = c.String(),
                        CourtFileNumber = c.Int(nullable: false),
                        SWCFileNumber = c.Int(nullable: false),
                        RiskAssessmentAssignedTo = c.String(),
                        AbuserName = c.String(),
                        NumChildren0_6 = c.Int(nullable: false),
                        NumChildren7_12 = c.Int(nullable: false),
                        NumChildren13_18 = c.Int(nullable: false),
                        DateLastTransferred = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReOpened = c.DateTime(nullable: false),
                        AbuserRelationship_AbuserRelationship = c.String(maxLength: 128),
                        Age_Age = c.String(maxLength: 128),
                        AssignedWorker_AssignedWorker = c.String(maxLength: 128),
                        Crisis_Crisis = c.String(maxLength: 128),
                        DuplicateFile_DuplicateFile = c.String(maxLength: 128),
                        Ethnicity_Ethnicity = c.String(maxLength: 128),
                        FamilyViolenceFile_FamilyViolenceFile = c.String(maxLength: 128),
                        FiscalYear_FiscalYear = c.String(maxLength: 128),
                        Incident_Incident = c.String(maxLength: 128),
                        Program_Program = c.String(maxLength: 128),
                        ReferralContact_ReferralContact = c.String(maxLength: 128),
                        ReferralSource_ReferralSource = c.String(maxLength: 128),
                        RepeatClient_RepeatClient = c.String(maxLength: 128),
                        RiskLevel_RiskLevel = c.String(maxLength: 128),
                        RiskStatus_RiskStatus = c.String(maxLength: 128),
                        Service_Service = c.String(maxLength: 128),
                        SmartModel_ClientReferenceNumber = c.Int(),
                        StatusOfFile_StatusOfFile = c.String(maxLength: 128),
                        VictimOfIncident_VictimOfIncident = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.AbuserRelationshipModels", t => t.AbuserRelationship_AbuserRelationship)
                .ForeignKey("dbo.AgeModels", t => t.Age_Age)
                .ForeignKey("dbo.AssignedWorkerModels", t => t.AssignedWorker_AssignedWorker)
                .ForeignKey("dbo.CrisisModels", t => t.Crisis_Crisis)
                .ForeignKey("dbo.DuplicateFileModels", t => t.DuplicateFile_DuplicateFile)
                .ForeignKey("dbo.EthnicityModels", t => t.Ethnicity_Ethnicity)
                .ForeignKey("dbo.FamilyViolenceModels", t => t.FamilyViolenceFile_FamilyViolenceFile)
                .ForeignKey("dbo.FiscalYearModels", t => t.FiscalYear_FiscalYear)
                .ForeignKey("dbo.IncidentModels", t => t.Incident_Incident)
                .ForeignKey("dbo.ProgramModels", t => t.Program_Program)
                .ForeignKey("dbo.ReferralContactModels", t => t.ReferralContact_ReferralContact)
                .ForeignKey("dbo.ReferralSourceModels", t => t.ReferralSource_ReferralSource)
                .ForeignKey("dbo.RepeatClientModels", t => t.RepeatClient_RepeatClient)
                .ForeignKey("dbo.RiskLevelModels", t => t.RiskLevel_RiskLevel)
                .ForeignKey("dbo.RiskStatusModels", t => t.RiskStatus_RiskStatus)
                .ForeignKey("dbo.ServiceModels", t => t.Service_Service)
                .ForeignKey("dbo.SmartModels", t => t.SmartModel_ClientReferenceNumber)
                .ForeignKey("dbo.StatusOfFileModels", t => t.StatusOfFile_StatusOfFile)
                .ForeignKey("dbo.VictimOfIncidentModels", t => t.VictimOfIncident_VictimOfIncident)
                .Index(t => t.AbuserRelationship_AbuserRelationship)
                .Index(t => t.Age_Age)
                .Index(t => t.AssignedWorker_AssignedWorker)
                .Index(t => t.Crisis_Crisis)
                .Index(t => t.DuplicateFile_DuplicateFile)
                .Index(t => t.Ethnicity_Ethnicity)
                .Index(t => t.FamilyViolenceFile_FamilyViolenceFile)
                .Index(t => t.FiscalYear_FiscalYear)
                .Index(t => t.Incident_Incident)
                .Index(t => t.Program_Program)
                .Index(t => t.ReferralContact_ReferralContact)
                .Index(t => t.ReferralSource_ReferralSource)
                .Index(t => t.RepeatClient_RepeatClient)
                .Index(t => t.RiskLevel_RiskLevel)
                .Index(t => t.RiskStatus_RiskStatus)
                .Index(t => t.Service_Service)
                .Index(t => t.SmartModel_ClientReferenceNumber)
                .Index(t => t.StatusOfFile_StatusOfFile)
                .Index(t => t.VictimOfIncident_VictimOfIncident);
            
            CreateTable(
                "dbo.AgeModels",
                c => new
                    {
                        Age = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Age);
            
            CreateTable(
                "dbo.AssignedWorkerModels",
                c => new
                    {
                        AssignedWorker = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.AssignedWorker);
            
            CreateTable(
                "dbo.CrisisModels",
                c => new
                    {
                        Crisis = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Crisis);
            
            CreateTable(
                "dbo.DuplicateFileModels",
                c => new
                    {
                        DuplicateFile = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.DuplicateFile);
            
            CreateTable(
                "dbo.EthnicityModels",
                c => new
                    {
                        Ethnicity = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Ethnicity);
            
            CreateTable(
                "dbo.FamilyViolenceModels",
                c => new
                    {
                        FamilyViolenceFile = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.FamilyViolenceFile);
            
            CreateTable(
                "dbo.FiscalYearModels",
                c => new
                    {
                        FiscalYear = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.FiscalYear);
            
            CreateTable(
                "dbo.IncidentModels",
                c => new
                    {
                        Incident = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Incident);
            
            CreateTable(
                "dbo.ProgramModels",
                c => new
                    {
                        Program = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Program);
            
            CreateTable(
                "dbo.ReferralContactModels",
                c => new
                    {
                        ReferralContact = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferralContact);
            
            CreateTable(
                "dbo.ReferralSourceModels",
                c => new
                    {
                        ReferralSource = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferralSource);
            
            CreateTable(
                "dbo.RepeatClientModels",
                c => new
                    {
                        RepeatClient = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.RepeatClient);
            
            CreateTable(
                "dbo.RiskLevelModels",
                c => new
                    {
                        RiskLevel = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.RiskLevel);
            
            CreateTable(
                "dbo.RiskStatusModels",
                c => new
                    {
                        RiskStatus = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.RiskStatus);
            
            CreateTable(
                "dbo.ServiceModels",
                c => new
                    {
                        Service = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Service);
            
            CreateTable(
                "dbo.SmartModels",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false, identity: true),
                        AccompanimentMinutes = c.Int(nullable: false),
                        NumberTransportsProvided = c.Int(nullable: false),
                        ReferredToNursePractitioner = c.Boolean(nullable: false),
                        BadDateReport_BadDateReport = c.String(maxLength: 128),
                        CityOfAssault_CityOfAssault = c.String(maxLength: 128),
                        CityOfResidence_CityOfResidence = c.String(maxLength: 128),
                        DrugFaciliatedAssault_DrugFacilitatedAssault = c.String(maxLength: 128),
                        EvidenceStored_EvidenceStored = c.String(maxLength: 128),
                        HIVMeds_HIVMeds = c.String(maxLength: 128),
                        HospitalAttended_HospitalAttended = c.String(maxLength: 128),
                        MedicalOnly_MedicalOnly = c.String(maxLength: 128),
                        MultiplePerpetrators_MultiplePerpetrators = c.String(maxLength: 128),
                        PoliceAttendance_PolicAttendance = c.String(maxLength: 128),
                        PoliceReported_PolicReported = c.String(maxLength: 128),
                        ReferralHospital_ReferralHospital = c.String(maxLength: 128),
                        ReferredToCBVS_ReferredCBVS = c.String(maxLength: 128),
                        SocialWorkAttendance_SocialWorkAttendance = c.String(maxLength: 128),
                        ThirdPartyReport_ThirdPartyReport = c.String(maxLength: 128),
                        VictimServices_VictimServices = c.String(maxLength: 128),
                        WorkExploitation_SexWorkExploitation = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.BadDateReportModels", t => t.BadDateReport_BadDateReport)
                .ForeignKey("dbo.CityOfAssaultModels", t => t.CityOfAssault_CityOfAssault)
                .ForeignKey("dbo.CityOfResidenceModels", t => t.CityOfResidence_CityOfResidence)
                .ForeignKey("dbo.DrugFacilitatedAssaultModels", t => t.DrugFaciliatedAssault_DrugFacilitatedAssault)
                .ForeignKey("dbo.EvidenceStoredModels", t => t.EvidenceStored_EvidenceStored)
                .ForeignKey("dbo.HIVMedsModels", t => t.HIVMeds_HIVMeds)
                .ForeignKey("dbo.HospitalAttendedModels", t => t.HospitalAttended_HospitalAttended)
                .ForeignKey("dbo.MedicalOnlyModels", t => t.MedicalOnly_MedicalOnly)
                .ForeignKey("dbo.MultiplePerpetratorsModels", t => t.MultiplePerpetrators_MultiplePerpetrators)
                .ForeignKey("dbo.PoliceAttendanceModels", t => t.PoliceAttendance_PolicAttendance)
                .ForeignKey("dbo.PoliceReportedModels", t => t.PoliceReported_PolicReported)
                .ForeignKey("dbo.ReferralHospitalModels", t => t.ReferralHospital_ReferralHospital)
                .ForeignKey("dbo.ReferredCBVSModels", t => t.ReferredToCBVS_ReferredCBVS)
                .ForeignKey("dbo.SocialWorkAttendanceModels", t => t.SocialWorkAttendance_SocialWorkAttendance)
                .ForeignKey("dbo.ThirdPartyReportModels", t => t.ThirdPartyReport_ThirdPartyReport)
                .ForeignKey("dbo.VictimServicesModels", t => t.VictimServices_VictimServices)
                .ForeignKey("dbo.Work_ExploitationModel", t => t.WorkExploitation_SexWorkExploitation)
                .Index(t => t.BadDateReport_BadDateReport)
                .Index(t => t.CityOfAssault_CityOfAssault)
                .Index(t => t.CityOfResidence_CityOfResidence)
                .Index(t => t.DrugFaciliatedAssault_DrugFacilitatedAssault)
                .Index(t => t.EvidenceStored_EvidenceStored)
                .Index(t => t.HIVMeds_HIVMeds)
                .Index(t => t.HospitalAttended_HospitalAttended)
                .Index(t => t.MedicalOnly_MedicalOnly)
                .Index(t => t.MultiplePerpetrators_MultiplePerpetrators)
                .Index(t => t.PoliceAttendance_PolicAttendance)
                .Index(t => t.PoliceReported_PolicReported)
                .Index(t => t.ReferralHospital_ReferralHospital)
                .Index(t => t.ReferredToCBVS_ReferredCBVS)
                .Index(t => t.SocialWorkAttendance_SocialWorkAttendance)
                .Index(t => t.ThirdPartyReport_ThirdPartyReport)
                .Index(t => t.VictimServices_VictimServices)
                .Index(t => t.WorkExploitation_SexWorkExploitation);
            
            CreateTable(
                "dbo.BadDateReportModels",
                c => new
                    {
                        BadDateReport = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.BadDateReport);
            
            CreateTable(
                "dbo.CityOfAssaultModels",
                c => new
                    {
                        CityOfAssault = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CityOfAssault);
            
            CreateTable(
                "dbo.CityOfResidenceModels",
                c => new
                    {
                        CityOfResidence = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CityOfResidence);
            
            CreateTable(
                "dbo.DrugFacilitatedAssaultModels",
                c => new
                    {
                        DrugFacilitatedAssault = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.DrugFacilitatedAssault);
            
            CreateTable(
                "dbo.EvidenceStoredModels",
                c => new
                    {
                        EvidenceStored = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EvidenceStored);
            
            CreateTable(
                "dbo.HIVMedsModels",
                c => new
                    {
                        HIVMeds = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.HIVMeds);
            
            CreateTable(
                "dbo.HospitalAttendedModels",
                c => new
                    {
                        HospitalAttended = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.HospitalAttended);
            
            CreateTable(
                "dbo.MedicalOnlyModels",
                c => new
                    {
                        MedicalOnly = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MedicalOnly);
            
            CreateTable(
                "dbo.MultiplePerpetratorsModels",
                c => new
                    {
                        MultiplePerpetrators = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MultiplePerpetrators);
            
            CreateTable(
                "dbo.PoliceAttendanceModels",
                c => new
                    {
                        PolicAttendance = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PolicAttendance);
            
            CreateTable(
                "dbo.PoliceReportedModels",
                c => new
                    {
                        PolicReported = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PolicReported);
            
            CreateTable(
                "dbo.ReferralHospitalModels",
                c => new
                    {
                        ReferralHospital = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferralHospital);
            
            CreateTable(
                "dbo.ReferredCBVSModels",
                c => new
                    {
                        ReferredCBVS = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferredCBVS);
            
            CreateTable(
                "dbo.SocialWorkAttendanceModels",
                c => new
                    {
                        SocialWorkAttendance = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SocialWorkAttendance);
            
            CreateTable(
                "dbo.ThirdPartyReportModels",
                c => new
                    {
                        ThirdPartyReport = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ThirdPartyReport);
            
            CreateTable(
                "dbo.VictimServicesModels",
                c => new
                    {
                        VictimServices = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.VictimServices);
            
            CreateTable(
                "dbo.Work_ExploitationModel",
                c => new
                    {
                        SexWorkExploitation = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SexWorkExploitation);
            
            CreateTable(
                "dbo.StatusOfFileModels",
                c => new
                    {
                        StatusOfFile = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.StatusOfFile);
            
            CreateTable(
                "dbo.VictimOfIncidentModels",
                c => new
                    {
                        VictimOfIncident = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.VictimOfIncident);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientModels", "VictimOfIncident_VictimOfIncident", "dbo.VictimOfIncidentModels");
            DropForeignKey("dbo.ClientModels", "StatusOfFile_StatusOfFile", "dbo.StatusOfFileModels");
            DropForeignKey("dbo.ClientModels", "SmartModel_ClientReferenceNumber", "dbo.SmartModels");
            DropForeignKey("dbo.SmartModels", "WorkExploitation_SexWorkExploitation", "dbo.Work_ExploitationModel");
            DropForeignKey("dbo.SmartModels", "VictimServices_VictimServices", "dbo.VictimServicesModels");
            DropForeignKey("dbo.SmartModels", "ThirdPartyReport_ThirdPartyReport", "dbo.ThirdPartyReportModels");
            DropForeignKey("dbo.SmartModels", "SocialWorkAttendance_SocialWorkAttendance", "dbo.SocialWorkAttendanceModels");
            DropForeignKey("dbo.SmartModels", "ReferredToCBVS_ReferredCBVS", "dbo.ReferredCBVSModels");
            DropForeignKey("dbo.SmartModels", "ReferralHospital_ReferralHospital", "dbo.ReferralHospitalModels");
            DropForeignKey("dbo.SmartModels", "PoliceReported_PolicReported", "dbo.PoliceReportedModels");
            DropForeignKey("dbo.SmartModels", "PoliceAttendance_PolicAttendance", "dbo.PoliceAttendanceModels");
            DropForeignKey("dbo.SmartModels", "MultiplePerpetrators_MultiplePerpetrators", "dbo.MultiplePerpetratorsModels");
            DropForeignKey("dbo.SmartModels", "MedicalOnly_MedicalOnly", "dbo.MedicalOnlyModels");
            DropForeignKey("dbo.SmartModels", "HospitalAttended_HospitalAttended", "dbo.HospitalAttendedModels");
            DropForeignKey("dbo.SmartModels", "HIVMeds_HIVMeds", "dbo.HIVMedsModels");
            DropForeignKey("dbo.SmartModels", "EvidenceStored_EvidenceStored", "dbo.EvidenceStoredModels");
            DropForeignKey("dbo.SmartModels", "DrugFaciliatedAssault_DrugFacilitatedAssault", "dbo.DrugFacilitatedAssaultModels");
            DropForeignKey("dbo.SmartModels", "CityOfResidence_CityOfResidence", "dbo.CityOfResidenceModels");
            DropForeignKey("dbo.SmartModels", "CityOfAssault_CityOfAssault", "dbo.CityOfAssaultModels");
            DropForeignKey("dbo.SmartModels", "BadDateReport_BadDateReport", "dbo.BadDateReportModels");
            DropForeignKey("dbo.ClientModels", "Service_Service", "dbo.ServiceModels");
            DropForeignKey("dbo.ClientModels", "RiskStatus_RiskStatus", "dbo.RiskStatusModels");
            DropForeignKey("dbo.ClientModels", "RiskLevel_RiskLevel", "dbo.RiskLevelModels");
            DropForeignKey("dbo.ClientModels", "RepeatClient_RepeatClient", "dbo.RepeatClientModels");
            DropForeignKey("dbo.ClientModels", "ReferralSource_ReferralSource", "dbo.ReferralSourceModels");
            DropForeignKey("dbo.ClientModels", "ReferralContact_ReferralContact", "dbo.ReferralContactModels");
            DropForeignKey("dbo.ClientModels", "Program_Program", "dbo.ProgramModels");
            DropForeignKey("dbo.ClientModels", "Incident_Incident", "dbo.IncidentModels");
            DropForeignKey("dbo.ClientModels", "FiscalYear_FiscalYear", "dbo.FiscalYearModels");
            DropForeignKey("dbo.ClientModels", "FamilyViolenceFile_FamilyViolenceFile", "dbo.FamilyViolenceModels");
            DropForeignKey("dbo.ClientModels", "Ethnicity_Ethnicity", "dbo.EthnicityModels");
            DropForeignKey("dbo.ClientModels", "DuplicateFile_DuplicateFile", "dbo.DuplicateFileModels");
            DropForeignKey("dbo.ClientModels", "Crisis_Crisis", "dbo.CrisisModels");
            DropForeignKey("dbo.ClientModels", "AssignedWorker_AssignedWorker", "dbo.AssignedWorkerModels");
            DropForeignKey("dbo.ClientModels", "Age_Age", "dbo.AgeModels");
            DropForeignKey("dbo.ClientModels", "AbuserRelationship_AbuserRelationship", "dbo.AbuserRelationshipModels");
            DropIndex("dbo.SmartModels", new[] { "WorkExploitation_SexWorkExploitation" });
            DropIndex("dbo.SmartModels", new[] { "VictimServices_VictimServices" });
            DropIndex("dbo.SmartModels", new[] { "ThirdPartyReport_ThirdPartyReport" });
            DropIndex("dbo.SmartModels", new[] { "SocialWorkAttendance_SocialWorkAttendance" });
            DropIndex("dbo.SmartModels", new[] { "ReferredToCBVS_ReferredCBVS" });
            DropIndex("dbo.SmartModels", new[] { "ReferralHospital_ReferralHospital" });
            DropIndex("dbo.SmartModels", new[] { "PoliceReported_PolicReported" });
            DropIndex("dbo.SmartModels", new[] { "PoliceAttendance_PolicAttendance" });
            DropIndex("dbo.SmartModels", new[] { "MultiplePerpetrators_MultiplePerpetrators" });
            DropIndex("dbo.SmartModels", new[] { "MedicalOnly_MedicalOnly" });
            DropIndex("dbo.SmartModels", new[] { "HospitalAttended_HospitalAttended" });
            DropIndex("dbo.SmartModels", new[] { "HIVMeds_HIVMeds" });
            DropIndex("dbo.SmartModels", new[] { "EvidenceStored_EvidenceStored" });
            DropIndex("dbo.SmartModels", new[] { "DrugFaciliatedAssault_DrugFacilitatedAssault" });
            DropIndex("dbo.SmartModels", new[] { "CityOfResidence_CityOfResidence" });
            DropIndex("dbo.SmartModels", new[] { "CityOfAssault_CityOfAssault" });
            DropIndex("dbo.SmartModels", new[] { "BadDateReport_BadDateReport" });
            DropIndex("dbo.ClientModels", new[] { "VictimOfIncident_VictimOfIncident" });
            DropIndex("dbo.ClientModels", new[] { "StatusOfFile_StatusOfFile" });
            DropIndex("dbo.ClientModels", new[] { "SmartModel_ClientReferenceNumber" });
            DropIndex("dbo.ClientModels", new[] { "Service_Service" });
            DropIndex("dbo.ClientModels", new[] { "RiskStatus_RiskStatus" });
            DropIndex("dbo.ClientModels", new[] { "RiskLevel_RiskLevel" });
            DropIndex("dbo.ClientModels", new[] { "RepeatClient_RepeatClient" });
            DropIndex("dbo.ClientModels", new[] { "ReferralSource_ReferralSource" });
            DropIndex("dbo.ClientModels", new[] { "ReferralContact_ReferralContact" });
            DropIndex("dbo.ClientModels", new[] { "Program_Program" });
            DropIndex("dbo.ClientModels", new[] { "Incident_Incident" });
            DropIndex("dbo.ClientModels", new[] { "FiscalYear_FiscalYear" });
            DropIndex("dbo.ClientModels", new[] { "FamilyViolenceFile_FamilyViolenceFile" });
            DropIndex("dbo.ClientModels", new[] { "Ethnicity_Ethnicity" });
            DropIndex("dbo.ClientModels", new[] { "DuplicateFile_DuplicateFile" });
            DropIndex("dbo.ClientModels", new[] { "Crisis_Crisis" });
            DropIndex("dbo.ClientModels", new[] { "AssignedWorker_AssignedWorker" });
            DropIndex("dbo.ClientModels", new[] { "Age_Age" });
            DropIndex("dbo.ClientModels", new[] { "AbuserRelationship_AbuserRelationship" });
            DropTable("dbo.UserModels");
            DropTable("dbo.VictimOfIncidentModels");
            DropTable("dbo.StatusOfFileModels");
            DropTable("dbo.Work_ExploitationModel");
            DropTable("dbo.VictimServicesModels");
            DropTable("dbo.ThirdPartyReportModels");
            DropTable("dbo.SocialWorkAttendanceModels");
            DropTable("dbo.ReferredCBVSModels");
            DropTable("dbo.ReferralHospitalModels");
            DropTable("dbo.PoliceReportedModels");
            DropTable("dbo.PoliceAttendanceModels");
            DropTable("dbo.MultiplePerpetratorsModels");
            DropTable("dbo.MedicalOnlyModels");
            DropTable("dbo.HospitalAttendedModels");
            DropTable("dbo.HIVMedsModels");
            DropTable("dbo.EvidenceStoredModels");
            DropTable("dbo.DrugFacilitatedAssaultModels");
            DropTable("dbo.CityOfResidenceModels");
            DropTable("dbo.CityOfAssaultModels");
            DropTable("dbo.BadDateReportModels");
            DropTable("dbo.SmartModels");
            DropTable("dbo.ServiceModels");
            DropTable("dbo.RiskStatusModels");
            DropTable("dbo.RiskLevelModels");
            DropTable("dbo.RepeatClientModels");
            DropTable("dbo.ReferralSourceModels");
            DropTable("dbo.ReferralContactModels");
            DropTable("dbo.ProgramModels");
            DropTable("dbo.IncidentModels");
            DropTable("dbo.FiscalYearModels");
            DropTable("dbo.FamilyViolenceModels");
            DropTable("dbo.EthnicityModels");
            DropTable("dbo.DuplicateFileModels");
            DropTable("dbo.CrisisModels");
            DropTable("dbo.AssignedWorkerModels");
            DropTable("dbo.AgeModels");
            DropTable("dbo.ClientModels");
            DropTable("dbo.AbuserRelationshipModels");
        }
    }
}
