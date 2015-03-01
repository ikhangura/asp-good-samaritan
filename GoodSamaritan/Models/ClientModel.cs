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

        [Range(0, 12, ErrorMessage = "valid month is between 1 to 12")]
        public int Month { get; set; }

        [Range(0, 31, ErrorMessage = "Valid days are between 1 to 31")]
        public int Day { get; set; }

        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Invalid Last Name")]
        public string Surname { get; set; }

         [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Invalid First Name")]
        public string FirstName { get; set; }

         [RegularExpression("^([0-9]{2}-[0-9]{5})$", ErrorMessage = "Format is 99-99999")]
        public string PoliceFileNumber { get; set; }

        [Range(1,int.MaxValue, ErrorMessage = "Value should be greater than 1")]
        public int CourtFileNumber { get; set; }

         [Range(0, int.MaxValue, ErrorMessage = "valid value is be zero or greater")]
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

        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "It should be some title\name")]
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

        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Not a valid name")]
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

          [Range(0, int.MaxValue, ErrorMessage = "Inter positive number please")]
        public int NumChildren0_6 { get; set; }

          [Range(0, int.MaxValue, ErrorMessage = "Inter positive number please")]
        public int NumChildren7_12 { get; set; }

          [Range(0, int.MaxValue, ErrorMessage = "Inter positive number please")]
        public int NumChildren13_18 { get; set; }

        [ForeignKey("StatusOfFile")]
        public int StatusOfFileId { get; set; }
        public StatusOfFileModel StatusOfFile { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastTransferred { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateReOpened { get; set; }
    }
}