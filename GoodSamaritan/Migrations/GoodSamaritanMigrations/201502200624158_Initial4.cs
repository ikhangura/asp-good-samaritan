namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationshipModels",
                c => new
                    {
                        AbuserRelationShipId = c.Int(nullable: false, identity: true),
                        AbuserRelationship = c.String(),
                    })
                .PrimaryKey(t => t.AbuserRelationShipId);
            
            CreateTable(
                "dbo.ClientModels",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false),
                        FiscalYearId = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNumber = c.String(),
                        CourtFileNumber = c.Int(nullable: false),
                        SWCFileNumber = c.Int(nullable: false),
                        RiskLevelId = c.Int(nullable: false),
                        CrisisId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        RiskAssessmentAssignedTo = c.String(),
                        RiskStatusId = c.Int(nullable: false),
                        AssignedWorkerId = c.Int(nullable: false),
                        ReferralSourceId = c.Int(nullable: false),
                        ReferralContactId = c.Int(nullable: false),
                        IncidentId = c.Int(nullable: false),
                        AbuserName = c.String(),
                        AbuserRelationshipId = c.Int(nullable: false),
                        VictimOfIncidentId = c.Int(nullable: false),
                        FamilyViolenceId = c.Int(nullable: false),
                        EthnicityId = c.Int(nullable: false),
                        AgeId = c.Int(nullable: false),
                        RepeatClientId = c.Int(nullable: false),
                        DuplicateFileId = c.Int(nullable: false),
                        NumChildren0_6 = c.Int(nullable: false),
                        NumChildren7_12 = c.Int(nullable: false),
                        NumChildren13_18 = c.Int(nullable: false),
                        StatusOfFileId = c.Int(nullable: false),
                        DateLastTransferred = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReOpened = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.AbuserRelationshipModels", t => t.AbuserRelationshipId, cascadeDelete: true)
                .ForeignKey("dbo.AgeModels", t => t.AgeId, cascadeDelete: true)
                .ForeignKey("dbo.AssignedWorkerModels", t => t.AssignedWorkerId, cascadeDelete: true)
                .ForeignKey("dbo.CrisisModels", t => t.CrisisId, cascadeDelete: true)
                .ForeignKey("dbo.DuplicateFileModels", t => t.DuplicateFileId, cascadeDelete: true)
                .ForeignKey("dbo.EthnicityModels", t => t.EthnicityId, cascadeDelete: true)
                .ForeignKey("dbo.FamilyViolenceModels", t => t.FamilyViolenceId, cascadeDelete: true)
                .ForeignKey("dbo.FiscalYearModels", t => t.FiscalYearId, cascadeDelete: true)
                .ForeignKey("dbo.IncidentModels", t => t.IncidentId, cascadeDelete: true)
                .ForeignKey("dbo.ProgramModels", t => t.ProgramId, cascadeDelete: true)
                .ForeignKey("dbo.ReferralContactModels", t => t.ReferralContactId, cascadeDelete: true)
                .ForeignKey("dbo.ReferralSourceModels", t => t.ReferralSourceId, cascadeDelete: true)
                .ForeignKey("dbo.RepeatClientModels", t => t.RepeatClientId, cascadeDelete: true)
                .ForeignKey("dbo.RiskLevelModels", t => t.RiskLevelId, cascadeDelete: true)
                .ForeignKey("dbo.RiskStatusModels", t => t.RiskStatusId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceModels", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.SmartModels", t => t.ClientReferenceNumber)
                .ForeignKey("dbo.StatusOfFileModels", t => t.StatusOfFileId, cascadeDelete: true)
                .ForeignKey("dbo.VictimOfIncidentModels", t => t.VictimOfIncidentId, cascadeDelete: true)
                .Index(t => t.ClientReferenceNumber)
                .Index(t => t.FiscalYearId)
                .Index(t => t.RiskLevelId)
                .Index(t => t.CrisisId)
                .Index(t => t.ServiceId)
                .Index(t => t.ProgramId)
                .Index(t => t.RiskStatusId)
                .Index(t => t.AssignedWorkerId)
                .Index(t => t.ReferralSourceId)
                .Index(t => t.ReferralContactId)
                .Index(t => t.IncidentId)
                .Index(t => t.AbuserRelationshipId)
                .Index(t => t.VictimOfIncidentId)
                .Index(t => t.FamilyViolenceId)
                .Index(t => t.EthnicityId)
                .Index(t => t.AgeId)
                .Index(t => t.RepeatClientId)
                .Index(t => t.DuplicateFileId)
                .Index(t => t.StatusOfFileId);
            
            CreateTable(
                "dbo.AgeModels",
                c => new
                    {
                        AgeId = c.Int(nullable: false, identity: true),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.AgeId);
            
            CreateTable(
                "dbo.AssignedWorkerModels",
                c => new
                    {
                        AssignedWorkerId = c.Int(nullable: false, identity: true),
                        AssignedWorker = c.String(),
                    })
                .PrimaryKey(t => t.AssignedWorkerId);
            
            CreateTable(
                "dbo.CrisisModels",
                c => new
                    {
                        CrisisId = c.Int(nullable: false, identity: true),
                        Crisis = c.String(),
                    })
                .PrimaryKey(t => t.CrisisId);
            
            CreateTable(
                "dbo.DuplicateFileModels",
                c => new
                    {
                        DuplicateFileId = c.Int(nullable: false, identity: true),
                        DuplicateFile = c.String(),
                    })
                .PrimaryKey(t => t.DuplicateFileId);
            
            CreateTable(
                "dbo.EthnicityModels",
                c => new
                    {
                        EthnicityId = c.Int(nullable: false, identity: true),
                        Ethnicity = c.String(),
                    })
                .PrimaryKey(t => t.EthnicityId);
            
            CreateTable(
                "dbo.FamilyViolenceModels",
                c => new
                    {
                        FamilyVolenceId = c.Int(nullable: false, identity: true),
                        FamilyViolenceFile = c.String(),
                    })
                .PrimaryKey(t => t.FamilyVolenceId);
            
            CreateTable(
                "dbo.FiscalYearModels",
                c => new
                    {
                        FicalYearId = c.Int(nullable: false, identity: true),
                        FiscalYear = c.String(),
                    })
                .PrimaryKey(t => t.FicalYearId);
            
            CreateTable(
                "dbo.IncidentModels",
                c => new
                    {
                        IncidentId = c.Int(nullable: false, identity: true),
                        Incident = c.String(),
                    })
                .PrimaryKey(t => t.IncidentId);
            
            CreateTable(
                "dbo.ProgramModels",
                c => new
                    {
                        ProgramId = c.Int(nullable: false, identity: true),
                        Program = c.String(),
                    })
                .PrimaryKey(t => t.ProgramId);
            
            CreateTable(
                "dbo.ReferralContactModels",
                c => new
                    {
                        ReferralContactId = c.Int(nullable: false, identity: true),
                        ReferralContact = c.String(),
                    })
                .PrimaryKey(t => t.ReferralContactId);
            
            CreateTable(
                "dbo.ReferralSourceModels",
                c => new
                    {
                        ReferralSourceId = c.Int(nullable: false, identity: true),
                        ReferralSource = c.String(),
                    })
                .PrimaryKey(t => t.ReferralSourceId);
            
            CreateTable(
                "dbo.RepeatClientModels",
                c => new
                    {
                        RepeatClientId = c.Int(nullable: false, identity: true),
                        RepeatClient = c.String(),
                    })
                .PrimaryKey(t => t.RepeatClientId);
            
            CreateTable(
                "dbo.RiskLevelModels",
                c => new
                    {
                        RiskLevelId = c.Int(nullable: false, identity: true),
                        RiskLevel = c.String(),
                    })
                .PrimaryKey(t => t.RiskLevelId);
            
            CreateTable(
                "dbo.RiskStatusModels",
                c => new
                    {
                        RiskStatusId = c.Int(nullable: false, identity: true),
                        RiskStatus = c.String(),
                    })
                .PrimaryKey(t => t.RiskStatusId);
            
            CreateTable(
                "dbo.ServiceModels",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Service = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.SmartModels",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false, identity: true),
                        WorkExploitationId = c.Int(nullable: false),
                        MultiplePErpetratorsId = c.Int(nullable: false),
                        DrugFaciliatedAssaultID = c.Int(nullable: false),
                        CityOfAssaultId = c.Int(nullable: false),
                        CityOfResidenceId = c.Int(nullable: false),
                        AccompanimentMinutes = c.Int(nullable: false),
                        ReferralHospitalId = c.Int(nullable: false),
                        HospitalAttendedId = c.Int(nullable: false),
                        SocialWorkAttendanceId = c.Int(nullable: false),
                        PoliceAttendanceID = c.Int(nullable: false),
                        VictimServicesId = c.Int(nullable: false),
                        MedicalOnlyId = c.Int(nullable: false),
                        EvidenceStoredId = c.Int(nullable: false),
                        HIVMedsId = c.Int(nullable: false),
                        ReferredToCBVSId = c.Int(nullable: false),
                        PoliceReportedId = c.Int(nullable: false),
                        ThirsPartyReportId = c.Int(nullable: false),
                        BadDateReportId = c.Int(nullable: false),
                        NumberTransportsProvided = c.Int(nullable: false),
                        ReferredToNursePractitioner = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.BadDateReportModels", t => t.BadDateReportId, cascadeDelete: true)
                .ForeignKey("dbo.CityOfAssaultModels", t => t.CityOfAssaultId, cascadeDelete: true)
                .ForeignKey("dbo.CityOfResidenceModels", t => t.CityOfResidenceId, cascadeDelete: true)
                .ForeignKey("dbo.DrugFacilitatedAssaultModels", t => t.DrugFaciliatedAssaultID, cascadeDelete: true)
                .ForeignKey("dbo.EvidenceStoredModels", t => t.EvidenceStoredId, cascadeDelete: true)
                .ForeignKey("dbo.HIVMedsModels", t => t.HIVMedsId, cascadeDelete: true)
                .ForeignKey("dbo.HospitalAttendedModels", t => t.HospitalAttendedId, cascadeDelete: true)
                .ForeignKey("dbo.MedicalOnlyModels", t => t.MedicalOnlyId, cascadeDelete: true)
                .ForeignKey("dbo.MultiplePerpetratorsModels", t => t.MultiplePErpetratorsId, cascadeDelete: true)
                .ForeignKey("dbo.PoliceAttendanceModels", t => t.PoliceAttendanceID, cascadeDelete: true)
                .ForeignKey("dbo.PoliceReportedModels", t => t.PoliceReportedId, cascadeDelete: true)
                .ForeignKey("dbo.ReferralHospitalModels", t => t.ReferralHospitalId, cascadeDelete: true)
                .ForeignKey("dbo.ReferredCBVSModels", t => t.ReferredToCBVSId, cascadeDelete: true)
                .ForeignKey("dbo.SocialWorkAttendanceModels", t => t.SocialWorkAttendanceId, cascadeDelete: true)
                .ForeignKey("dbo.ThirdPartyReportModels", t => t.ThirsPartyReportId, cascadeDelete: true)
                .ForeignKey("dbo.VictimServicesModels", t => t.VictimServicesId, cascadeDelete: true)
                .ForeignKey("dbo.Work_ExploitationModel", t => t.WorkExploitationId, cascadeDelete: true)
                .Index(t => t.WorkExploitationId)
                .Index(t => t.MultiplePErpetratorsId)
                .Index(t => t.DrugFaciliatedAssaultID)
                .Index(t => t.CityOfAssaultId)
                .Index(t => t.CityOfResidenceId)
                .Index(t => t.ReferralHospitalId)
                .Index(t => t.HospitalAttendedId)
                .Index(t => t.SocialWorkAttendanceId)
                .Index(t => t.PoliceAttendanceID)
                .Index(t => t.VictimServicesId)
                .Index(t => t.MedicalOnlyId)
                .Index(t => t.EvidenceStoredId)
                .Index(t => t.HIVMedsId)
                .Index(t => t.ReferredToCBVSId)
                .Index(t => t.PoliceReportedId)
                .Index(t => t.ThirsPartyReportId)
                .Index(t => t.BadDateReportId);
            
            CreateTable(
                "dbo.BadDateReportModels",
                c => new
                    {
                        BadDateReportId = c.Int(nullable: false, identity: true),
                        BadDateReport = c.String(),
                    })
                .PrimaryKey(t => t.BadDateReportId);
            
            CreateTable(
                "dbo.CityOfAssaultModels",
                c => new
                    {
                        CityOfAssaultId = c.Int(nullable: false, identity: true),
                        CityOfAssault = c.String(),
                    })
                .PrimaryKey(t => t.CityOfAssaultId);
            
            CreateTable(
                "dbo.CityOfResidenceModels",
                c => new
                    {
                        CityOfResidenceId = c.Int(nullable: false, identity: true),
                        CityOfResidence = c.String(),
                    })
                .PrimaryKey(t => t.CityOfResidenceId);
            
            CreateTable(
                "dbo.DrugFacilitatedAssaultModels",
                c => new
                    {
                        DrugFacilitatedAssaultId = c.Int(nullable: false, identity: true),
                        DrugFacilitatedAssault = c.String(),
                    })
                .PrimaryKey(t => t.DrugFacilitatedAssaultId);
            
            CreateTable(
                "dbo.EvidenceStoredModels",
                c => new
                    {
                        EvidenceStoredId = c.Int(nullable: false, identity: true),
                        EvidenceStored = c.String(),
                    })
                .PrimaryKey(t => t.EvidenceStoredId);
            
            CreateTable(
                "dbo.HIVMedsModels",
                c => new
                    {
                        HIVMedsId = c.Int(nullable: false, identity: true),
                        HIVMeds = c.String(),
                    })
                .PrimaryKey(t => t.HIVMedsId);
            
            CreateTable(
                "dbo.HospitalAttendedModels",
                c => new
                    {
                        HospitalAttendedId = c.Int(nullable: false, identity: true),
                        HospitalAttended = c.String(),
                    })
                .PrimaryKey(t => t.HospitalAttendedId);
            
            CreateTable(
                "dbo.MedicalOnlyModels",
                c => new
                    {
                        MedicalOnlyId = c.Int(nullable: false, identity: true),
                        MedicalOnly = c.String(),
                    })
                .PrimaryKey(t => t.MedicalOnlyId);
            
            CreateTable(
                "dbo.MultiplePerpetratorsModels",
                c => new
                    {
                        MultiplePerpetratorsID = c.Int(nullable: false, identity: true),
                        MultiplePerpetrators = c.String(),
                    })
                .PrimaryKey(t => t.MultiplePerpetratorsID);
            
            CreateTable(
                "dbo.PoliceAttendanceModels",
                c => new
                    {
                        PoliceAttendanceId = c.Int(nullable: false, identity: true),
                        PolicAttendance = c.String(),
                    })
                .PrimaryKey(t => t.PoliceAttendanceId);
            
            CreateTable(
                "dbo.PoliceReportedModels",
                c => new
                    {
                        PoliceReportedId = c.Int(nullable: false, identity: true),
                        PolicReported = c.String(),
                    })
                .PrimaryKey(t => t.PoliceReportedId);
            
            CreateTable(
                "dbo.ReferralHospitalModels",
                c => new
                    {
                        ReferralHospitalID = c.Int(nullable: false, identity: true),
                        ReferralHospital = c.String(),
                    })
                .PrimaryKey(t => t.ReferralHospitalID);
            
            CreateTable(
                "dbo.ReferredCBVSModels",
                c => new
                    {
                        ReferralCBVSID = c.Int(nullable: false, identity: true),
                        ReferredCBVS = c.String(),
                    })
                .PrimaryKey(t => t.ReferralCBVSID);
            
            CreateTable(
                "dbo.SocialWorkAttendanceModels",
                c => new
                    {
                        SocalWorkAttendanceId = c.Int(nullable: false, identity: true),
                        SocialWorkAttendance = c.String(),
                    })
                .PrimaryKey(t => t.SocalWorkAttendanceId);
            
            CreateTable(
                "dbo.ThirdPartyReportModels",
                c => new
                    {
                        ThirdPartyReportID = c.Int(nullable: false, identity: true),
                        ThirdPartyReport = c.String(),
                    })
                .PrimaryKey(t => t.ThirdPartyReportID);
            
            CreateTable(
                "dbo.VictimServicesModels",
                c => new
                    {
                        VictimServicesID = c.Int(nullable: false, identity: true),
                        VictimServices = c.String(),
                    })
                .PrimaryKey(t => t.VictimServicesID);
            
            CreateTable(
                "dbo.Work_ExploitationModel",
                c => new
                    {
                        SexWorkExploitationId = c.Int(nullable: false, identity: true),
                        SexWorkExploitation = c.String(),
                    })
                .PrimaryKey(t => t.SexWorkExploitationId);
            
            CreateTable(
                "dbo.StatusOfFileModels",
                c => new
                    {
                        StatusOfFileId = c.Int(nullable: false, identity: true),
                        StatusOfFile = c.String(),
                    })
                .PrimaryKey(t => t.StatusOfFileId);
            
            CreateTable(
                "dbo.VictimOfIncidentModels",
                c => new
                    {
                        VictimOFIncidentId = c.Int(nullable: false, identity: true),
                        VictimOfIncident = c.String(),
                    })
                .PrimaryKey(t => t.VictimOFIncidentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientModels", "VictimOfIncidentId", "dbo.VictimOfIncidentModels");
            DropForeignKey("dbo.ClientModels", "StatusOfFileId", "dbo.StatusOfFileModels");
            DropForeignKey("dbo.ClientModels", "ClientReferenceNumber", "dbo.SmartModels");
            DropForeignKey("dbo.SmartModels", "WorkExploitationId", "dbo.Work_ExploitationModel");
            DropForeignKey("dbo.SmartModels", "VictimServicesId", "dbo.VictimServicesModels");
            DropForeignKey("dbo.SmartModels", "ThirsPartyReportId", "dbo.ThirdPartyReportModels");
            DropForeignKey("dbo.SmartModels", "SocialWorkAttendanceId", "dbo.SocialWorkAttendanceModels");
            DropForeignKey("dbo.SmartModels", "ReferredToCBVSId", "dbo.ReferredCBVSModels");
            DropForeignKey("dbo.SmartModels", "ReferralHospitalId", "dbo.ReferralHospitalModels");
            DropForeignKey("dbo.SmartModels", "PoliceReportedId", "dbo.PoliceReportedModels");
            DropForeignKey("dbo.SmartModels", "PoliceAttendanceID", "dbo.PoliceAttendanceModels");
            DropForeignKey("dbo.SmartModels", "MultiplePErpetratorsId", "dbo.MultiplePerpetratorsModels");
            DropForeignKey("dbo.SmartModels", "MedicalOnlyId", "dbo.MedicalOnlyModels");
            DropForeignKey("dbo.SmartModels", "HospitalAttendedId", "dbo.HospitalAttendedModels");
            DropForeignKey("dbo.SmartModels", "HIVMedsId", "dbo.HIVMedsModels");
            DropForeignKey("dbo.SmartModels", "EvidenceStoredId", "dbo.EvidenceStoredModels");
            DropForeignKey("dbo.SmartModels", "DrugFaciliatedAssaultID", "dbo.DrugFacilitatedAssaultModels");
            DropForeignKey("dbo.SmartModels", "CityOfResidenceId", "dbo.CityOfResidenceModels");
            DropForeignKey("dbo.SmartModels", "CityOfAssaultId", "dbo.CityOfAssaultModels");
            DropForeignKey("dbo.SmartModels", "BadDateReportId", "dbo.BadDateReportModels");
            DropForeignKey("dbo.ClientModels", "ServiceId", "dbo.ServiceModels");
            DropForeignKey("dbo.ClientModels", "RiskStatusId", "dbo.RiskStatusModels");
            DropForeignKey("dbo.ClientModels", "RiskLevelId", "dbo.RiskLevelModels");
            DropForeignKey("dbo.ClientModels", "RepeatClientId", "dbo.RepeatClientModels");
            DropForeignKey("dbo.ClientModels", "ReferralSourceId", "dbo.ReferralSourceModels");
            DropForeignKey("dbo.ClientModels", "ReferralContactId", "dbo.ReferralContactModels");
            DropForeignKey("dbo.ClientModels", "ProgramId", "dbo.ProgramModels");
            DropForeignKey("dbo.ClientModels", "IncidentId", "dbo.IncidentModels");
            DropForeignKey("dbo.ClientModels", "FiscalYearId", "dbo.FiscalYearModels");
            DropForeignKey("dbo.ClientModels", "FamilyViolenceId", "dbo.FamilyViolenceModels");
            DropForeignKey("dbo.ClientModels", "EthnicityId", "dbo.EthnicityModels");
            DropForeignKey("dbo.ClientModels", "DuplicateFileId", "dbo.DuplicateFileModels");
            DropForeignKey("dbo.ClientModels", "CrisisId", "dbo.CrisisModels");
            DropForeignKey("dbo.ClientModels", "AssignedWorkerId", "dbo.AssignedWorkerModels");
            DropForeignKey("dbo.ClientModels", "AgeId", "dbo.AgeModels");
            DropForeignKey("dbo.ClientModels", "AbuserRelationshipId", "dbo.AbuserRelationshipModels");
            DropIndex("dbo.SmartModels", new[] { "BadDateReportId" });
            DropIndex("dbo.SmartModels", new[] { "ThirsPartyReportId" });
            DropIndex("dbo.SmartModels", new[] { "PoliceReportedId" });
            DropIndex("dbo.SmartModels", new[] { "ReferredToCBVSId" });
            DropIndex("dbo.SmartModels", new[] { "HIVMedsId" });
            DropIndex("dbo.SmartModels", new[] { "EvidenceStoredId" });
            DropIndex("dbo.SmartModels", new[] { "MedicalOnlyId" });
            DropIndex("dbo.SmartModels", new[] { "VictimServicesId" });
            DropIndex("dbo.SmartModels", new[] { "PoliceAttendanceID" });
            DropIndex("dbo.SmartModels", new[] { "SocialWorkAttendanceId" });
            DropIndex("dbo.SmartModels", new[] { "HospitalAttendedId" });
            DropIndex("dbo.SmartModels", new[] { "ReferralHospitalId" });
            DropIndex("dbo.SmartModels", new[] { "CityOfResidenceId" });
            DropIndex("dbo.SmartModels", new[] { "CityOfAssaultId" });
            DropIndex("dbo.SmartModels", new[] { "DrugFaciliatedAssaultID" });
            DropIndex("dbo.SmartModels", new[] { "MultiplePErpetratorsId" });
            DropIndex("dbo.SmartModels", new[] { "WorkExploitationId" });
            DropIndex("dbo.ClientModels", new[] { "StatusOfFileId" });
            DropIndex("dbo.ClientModels", new[] { "DuplicateFileId" });
            DropIndex("dbo.ClientModels", new[] { "RepeatClientId" });
            DropIndex("dbo.ClientModels", new[] { "AgeId" });
            DropIndex("dbo.ClientModels", new[] { "EthnicityId" });
            DropIndex("dbo.ClientModels", new[] { "FamilyViolenceId" });
            DropIndex("dbo.ClientModels", new[] { "VictimOfIncidentId" });
            DropIndex("dbo.ClientModels", new[] { "AbuserRelationshipId" });
            DropIndex("dbo.ClientModels", new[] { "IncidentId" });
            DropIndex("dbo.ClientModels", new[] { "ReferralContactId" });
            DropIndex("dbo.ClientModels", new[] { "ReferralSourceId" });
            DropIndex("dbo.ClientModels", new[] { "AssignedWorkerId" });
            DropIndex("dbo.ClientModels", new[] { "RiskStatusId" });
            DropIndex("dbo.ClientModels", new[] { "ProgramId" });
            DropIndex("dbo.ClientModels", new[] { "ServiceId" });
            DropIndex("dbo.ClientModels", new[] { "CrisisId" });
            DropIndex("dbo.ClientModels", new[] { "RiskLevelId" });
            DropIndex("dbo.ClientModels", new[] { "FiscalYearId" });
            DropIndex("dbo.ClientModels", new[] { "ClientReferenceNumber" });
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
