using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodSamaritan.Models.LookupTables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

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

        [Display(Name = "First Name")]
        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Invalid First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Police File Number")]
        [RegularExpression("^([0-9]{2}-[0-9]{5})$", ErrorMessage = "Format is 99-99999")]
        public string PoliceFileNumber { get; set; }

        [Display(Name = "Court File Number")]
        [Range(1,int.MaxValue, ErrorMessage = "Value should be greater than 1")]
        public int CourtFileNumber { get; set; }

        [ReadOnly(true)]
        [Display(Name = "SWC File Number")]
        [Range(0, int.MaxValue, ErrorMessage = "valid value is be zero or greater")]
        public int SWCFileNumber { get; set; }

        [Display(Name = "Risk Level")]
        [ForeignKey("RiskLevel")]
        public int RiskLevelId { get; set; }
        public RiskLevelModel RiskLevel { get; set; }

        [Display(Name = "Crisis")]
        [ForeignKey("Crisis")]
        public int CrisisId { get; set; }
        public CrisisModel Crisis { get; set; }

        [Display(Name = "Service")]
        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public ServiceModel Service { get; set; }

        [Display(Name = "Program")]
        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public ProgramModel Program { get; set; }

        [Display(Name = "Risk Assessment Assigned To")]
        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "It should be some title\name")]
        public string RiskAssessmentAssignedTo { get; set; }

        [Display(Name = "Risk Status")]
        [ForeignKey("RiskStatus")]
        public int RiskStatusId { get; set; }
        public RiskStatusModel RiskStatus { get; set; }

        [Display(Name = "Assigned Worker")]
        [ForeignKey("AssignedWorker")]
        public int AssignedWorkerId { get; set; }
        public AssignedWorkerModel AssignedWorker { get; set; }

        [Display(Name = "Referral Source")]
        [ForeignKey("ReferralSource")]
        public int ReferralSourceId { get; set; }
        public ReferralSourceModel ReferralSource { get; set; }

        [Display(Name = "Referral Contact")]
        [ForeignKey("ReferralContact")]
        public int ReferralContactId { get; set; }
        public ReferralContactModel ReferralContact { get; set; }

        [Display(Name = "Incident")]
        [ForeignKey("Incident")]
        public int IncidentId { get; set; }
        public IncidentModel Incident { get; set; }

        [Display(Name = "Abuser Name")]
        [RegularExpression("^([a-zA-Z]+)$", ErrorMessage = "Not a valid name")]
        public string AbuserName { get; set; }

        [Display(Name = "Abuser Relationship")]
        [ForeignKey("AbuserRelationship")]
        public int AbuserRelationshipId { get; set; }
        public AbuserRelationshipModel AbuserRelationship { get; set; }

        [Display(Name = "Victim Of Incident")]
        [ForeignKey("VictimOfIncident")]
        public int VictimOfIncidentId { get; set; }
        public VictimOfIncidentModel VictimOfIncident { get; set; }

        [Display(Name = "Family Violence File")]
        [ForeignKey("FamilyViolenceFile")]
        public int FamilyViolenceId { get; set; }
        public FamilyViolenceModel FamilyViolenceFile { get; set; }

        [RegularExpression("^M|F|Trans$")]
        public char Gender { get; set; }

        [Display(Name = "Ethnicity")]
        [ForeignKey("Ethnicity")]
        public int EthnicityId { get; set; }
        public EthnicityModel Ethnicity { get; set; }

        [Display(Name = "Age")]
        [ForeignKey("Age")]
        public int AgeId { get; set; }
        public AgeModel Age { get; set; }

        [Display(Name = "Repeat Client")]
        [ForeignKey("RepeatClient")]
        public int RepeatClientId { get; set; }
        public RepeatClientModel RepeatClient { get; set; }

        [Display(Name = "Duplicate File")]
        [ForeignKey("DuplicateFile")]
        public int DuplicateFileId { get; set; }
        public DuplicateFileModel DuplicateFile { get; set; }

        [Display(Name = "Number Of Children (Age 0-6)")]
        [Range(0, int.MaxValue, ErrorMessage = "Inter positive number please")]
        public int NumChildren0_6 { get; set; }

        [Display(Name = "Number Of Children (Age 7-12)")]
        [Range(0, int.MaxValue, ErrorMessage = "Inter positive number please")]
        public int NumChildren7_12 { get; set; }

        [Display(Name = "Number Of Children (Age 13-18)")]
        [Range(0, int.MaxValue, ErrorMessage = "Inter positive number please")]
        public int NumChildren13_18 { get; set; }

        [Display(Name = "Status Of File")]
        [ForeignKey("StatusOfFile")]
        public int StatusOfFileId { get; set; }
        public StatusOfFileModel StatusOfFile { get; set; }

        [Display(Name = "Date Last Transferred")]
        [DataType(DataType.Date)]
        public DateTime DateLastTransferred { get; set; }

        [Display(Name = "Date Closed")]
        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }

        [Display(Name = "Date Re-Opened")]
        [DataType(DataType.Date)]
        public DateTime DateReOpened { get; set; }
    }
}