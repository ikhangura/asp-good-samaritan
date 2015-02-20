using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodSamaritan.Models.LookupTables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodSamaritan.Models
{
    public class ClientModel
    {
        [Key]
        [ForeignKey("SmartModel")]
        public int ClientReferenceNumber { get; set; }

        public SmartModel SmartModel { get; set; }

        [ForeignKey("FiscalYear")]
        public int FiscalYearId { get; set; }
        public FiscalYearModel FiscalYear { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public string PoliceFileNumber { get; set; }

        public int CourtFileNumber { get; set; }

        public int SWCFileNumber { get; set; }

        [ForeignKey("RiskLevel")]
        public int RiskLevelId { get; set; }
        public RiskLevelModel RiskLevel { get; set; }

        [ForeignKey("Crisis")]
        public int CrisisId { get; set; }
        public CrisisModel Crisis { get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public ServiceModel Service { get; set; }

        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public ProgramModel Program { get; set; }

        public string RiskAssessmentAssignedTo { get; set; }

        [ForeignKey("RiskStatus")]
        public int RiskStatusId { get; set; }
        public RiskStatusModel RiskStatus { get; set; }

        [ForeignKey("AssignedWorker")]
        public int AssignedWorkerId { get; set; }
        public AssignedWorkerModel AssignedWorker { get; set; }

        [ForeignKey("ReferralSource")]
        public int ReferralSourceId { get; set; }
        public ReferralSourceModel ReferralSource { get; set; }

        [ForeignKey("ReferralContact")]
        public int ReferralContactId { get; set; }
        public ReferralContactModel ReferralContact { get; set; }

        [ForeignKey("Incident")]
        public int IncidentId { get; set; }
        public IncidentModel Incident { get; set; }

        public string AbuserName { get; set; }

        [ForeignKey("AbuserRelationship")]
        public int AbuserRelationshipId { get; set; }
        public AbuserRelationshipModel AbuserRelationship { get; set; }

        [ForeignKey("VictimOfIncident")]
        public int VictimOfIncidentId { get; set; }
        public VictimOfIncidentModel VictimOfIncident { get; set; }

        [ForeignKey("FamilyViolenceFile")]
        public int FamilyViolenceId { get; set; }
        public FamilyViolenceModel FamilyViolenceFile { get; set; }

        public char Gender { get; set; }

        [ForeignKey("Ethnicity")]
        public int EthnicityId { get; set; }
        public EthnicityModel Ethnicity { get; set; }

        [ForeignKey("Age")]
        public int AgeId { get; set; }
        public AgeModel Age { get; set; }

        [ForeignKey("RepeatClient")]
        public int RepeatClientId { get; set; }
        public RepeatClientModel RepeatClient { get; set; }

        [ForeignKey("DuplicateFile")]
        public int DuplicateFileId { get; set; }
        public DuplicateFileModel DuplicateFile { get; set; }

        public int NumChildren0_6 { get; set; }

        public int NumChildren7_12 { get; set; }

        public int NumChildren13_18 { get; set; }

        [ForeignKey("StatusOfFile")]
        public int StatusOfFileId { get; set; }
        public StatusOfFileModel StatusOfFile { get; set; }

        public DateTime DateLastTransferred { get; set; }

        public DateTime DateClosed { get; set; }

        public DateTime DateReOpened { get; set; }
    }
}